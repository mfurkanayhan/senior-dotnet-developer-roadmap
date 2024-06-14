using ITDesk.Server.DTOs;
using ITDesk.Server.Models;
using ITDesk.Server.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ITDesk.Server.Services;

public sealed class JwtProvider
{
    private readonly Jwt _jwt;

    public JwtProvider(IOptions<Jwt> jwt)
    {
        _jwt = jwt.Value;        
    }

    public LoginResponseDto CreateToken(User user, bool rememberMe)
    {
        List<Claim> claims = new()
        {
            new Claim("UserId", user.Id.ToString()),
            new Claim("UserName", user.UserName),
            new Claim(ClaimTypes.Email, user.Email)
        };  // Key and Value

        DateTime expires = rememberMe ? DateTime.Now.AddMonths(1) : DateTime.Now.AddDays(1);

        string secretKey = _jwt.SecretKey;

        var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        var credentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha512);

        JwtSecurityToken securityToken = new(
            issuer: _jwt.Issuer, // The entity that issues the token
            audience: _jwt.Audience, // The intended recipient of the token
            claims: claims, // The claims (user information) contained in the token
            notBefore: DateTime.Now, // The time before which the token is not valid
            expires: expires, // The expiration time of the token
            signingCredentials: credentials // The credentials used to sign the token
        );

        JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
        string token = handler.WriteToken( securityToken );

        return new(token, user.Id);
    }
}
