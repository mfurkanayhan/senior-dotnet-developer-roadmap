namespace Server.WebApi.Models;
// #nullable disable //Null kontrolü uyarısını bu sayede kapatabiliriz.

public sealed class Project
{
    public int Id { get; set; }
    // Null kontrolü '?' kullanarakta yapılabilir. Örneğin;
    public string? Name { get; set; }
    public string? Link { get; set; }
    public string? GitHubRepo { get; set; }
    // Non-nullable bir property oluştururken default bir değer atayarak Null kontrolü uyarısından kurtulabiliriz.
    public string CoverImageUrl { get; set; } = string.Empty;

    /*Non-nullable uyarsını kaldırmak isterseniz;
        Properties -> Build -> General -> Nullable = Disable
    */
}

public sealed class ProjectTechnologies
{
    public int Id { get; set; }
}

// public private protected internal
// access modifier - erişim belirleyicisi
