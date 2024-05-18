namespace DomainDrivenDesign.Domain.Orders;

public sealed record OrderNumber
{
    public string Value { get; init; }

    public OrderNumber(string value)
    {
        if(value.Length == 16)  // MFA2024000000001
        {
            throw new ArgumentException("Order number must be 16 length");
        }

        Value = value;
    }
};
