﻿namespace DomainDrivenDesign.Domain.Products;

public sealed record Money(decimal Amount, Currency Currency)
{
    public static Money operator +(Money a, Money b)
    {
        if(a.Currency != b.Currency)
        {
            throw new ArgumentException("Currencies with different values cannot be summed.");
        }
        return new(a.Amount + b.Amount, a.Currency);
    }
    public static Money Zero() => new(0, Currency.TRY);
    public static Money Zero(Currency currency) => new(0, currency);
    public bool IsZero() => this == Zero(Currency);
}
