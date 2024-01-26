public sealed record Money(decimal Amount,Currency Currency)
{
    public static Money operator +(Money money1, Money money2)
    {
        if (money1.Currency != money2.Currency)
        {
            throw new InvalidOperationException("Cannot add money with different currencies");
        }

        return new Money(money1.Amount + money2.Amount, money1.Currency);
    }

    public static Money operator -(Money money1, Money money2)
    {
        if (money1.Currency != money2.Currency)
        {
            throw new InvalidOperationException("Cannot subtract money with different currencies");
        }

        return new Money(money1.Amount - money2.Amount, money1.Currency);
    }

    public static Money Zero() => new(0, Currency.Default);
    public static Money Zero(Currency currency) => new(0, currency);
    public bool IsZero() => this == Zero(Currency);
}