public sealed record Email
{
    public string Value { get; init; }

    public Email(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException(nameof(value), "Email cannot be empty");
        }

        if (!value.Contains("@"))
        {
            throw new ArgumentException("Email is invalid", nameof(value));
        }

        Value = value;
    }
}