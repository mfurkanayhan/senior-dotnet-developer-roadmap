namespace DomainDrivenDesign.Domain.Products;

public sealed record Description
{
    public Description(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("The description field cannot be empty.");
        }

        if (value.Length > 50)
        {
            throw new ArgumentException("The description field must be at least 50 characters long.");
        }

        Value = value;
    }

    public string Value { get; init; }
}
