using ITDesk.Server.Context;
using ITDesk.Server.DTOs;
using ITDesk.Server.Models;
using ITDesk.Server.Validators;

namespace ITDesk.Server.Services;

public sealed class AuthService
{
    private readonly ApplicationDbContext _context;
    private readonly JwtProvider _jwtProvider;

    public AuthService(ApplicationDbContext context, JwtProvider jwtProvider)
    {
        _context = context;
        _jwtProvider = jwtProvider;        
    }

    public void Register(RegisterDto request)
    {
        #region Validation Check
        CheckValidation(request);
        #endregion

        #region UserName and Email Existence Check
        CheckUsernameAndEmailIsExists(request);
        #endregion

        #region Create Password
        byte[] passwordSalt, passwordHash;

        PasswordService.CreatePassword(request.Password, out passwordSalt, out passwordHash);
        #endregion

        #region Create User Object
        User user = CreateUser(request, passwordSalt, passwordHash);
        #endregion

        #region User Database Registration
        CreatingUserToDatabase(user);
        #endregion
    }

    public LoginResponseDto Login(LoginDto request)
    {
        #region Validation Check
        CheckValidation(request);
        #endregion

        // Immutable objects are objects whose state cannot be modified after they are created.
        // Once an immutable object is set, its value cannot be changed.
        // This is useful in various programming scenarios to ensure data integrity and avoid side effects.

        User? user = 
            _context.Users
            .FirstOrDefault(p => p.UserName == request.UsernameOrEmail || p.Email == request.UsernameOrEmail);

        if (user is null) // Business Logic
        {
            throw new ArgumentException("User not found");
        }

        var checkPasswordIsTrue = PasswordService.CheckPassword(user, request.Password);

        if (!checkPasswordIsTrue) // Business Logic
        {
            throw new ArgumentException("Incorrect password");
        }

        return _jwtProvider.CreateToken(user, request.RememberMe);
    }

    private void CreatingUserToDatabase(User user)
    {
        _context.Add(user);
        _context.SaveChanges();
    }

    private User CreateUser(RegisterDto request, byte[] passwordSalt, byte[] passwordHash)
    {
        return new()
        {
            Name = request.Name,
            LastName = request.LastName,
            PasswordHash = passwordHash,
            PasswordSalt = passwordSalt,
            Email = request.Email,
            UserName = request.Username
        };
    }

    private void CheckUsernameAndEmailIsExists(RegisterDto request)
    {
        var checkUsernameIsExists = _context.Users.Any(p => p.UserName == request.Username);
        if (checkUsernameIsExists)
        {
            throw new ArgumentException("This username is already taken");
        }

        var checkEmailIsExist = _context.Users.Any(p => p.Email == request.Email);
        if (checkEmailIsExist) 
        {
            throw new ArgumentException("This email address is already taken");
        }
    }

    private void CheckValidation<T>(T request) where T : class
    {
        string validatorName = typeof(T).FullName + "Validator";
        Type? validatorType = Type.GetType(validatorName);

        if (validatorType == null)
        {
            throw new InvalidOperationException("Validator class not found for " + typeof(T).FullName);
        }

        var validatorInstance = Activator.CreateInstance(validatorType);
        var validateMethod = validatorType.GetMethod("Validator");

        if (validateMethod == null)
        {
            throw new InvalidOperationException("Validate method not found in " + validatorName);
        }

        var result = validateMethod.Invoke(validatorInstance, new object[] { request });

        if (result is FluentValidation.Results.ValidationResult validationResult && !validationResult.IsValid)
        {
            throw new ArgumentException(validationResult.Errors[0].ErrorMessage);
        }
    }

    private void CheckValidation(RegisterDto request)
    {
        var validator = new RegisterDtoValidator();
        var result = validator.Validate(request);

        if (!result.IsValid)
        {
            throw new ArgumentException(result.Errors[0].ErrorMessage);
        }
    }

    private void CheckValidation(LoginDto request) 
    {
        var validator = new LoginDtoValidator();
        var result = validator.Validate(request);

        if (!result.IsValid)
        {
            throw new ArgumentException(result.Errors[0].ErrorMessage);            
        }
    }
}
