namespace PersonnelRegistrationApp.WebAPI.Models;

public class Personnel
{
    // public string FirstName; // Variable
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty; // "" // Property
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Avatar { get; set; } = string.Empty;
    public DateTime CreatedTime { get; set; }
}
