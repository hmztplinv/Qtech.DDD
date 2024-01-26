public sealed record Name
{
    public string Value { get;init; }

    public Name(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException(nameof(value), "Name cannot be empty");
        }

        if (value.Length < 3)
        {
            throw new ArgumentException("Name cannot be less than 3 characters", nameof(value));
        }

        Value = value;
    }
}