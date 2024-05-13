namespace DomainDrivenDesign.Domain.Products;

public sealed record Name
{
    public Name(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("The name field cannot be empty.");
        }

        if (value.Length < 3)
        {
            throw new ArgumentException("The name field must be at least 3 characters long.");
        }

        Value = value;
    }
    public string Value { get; init; }
}
