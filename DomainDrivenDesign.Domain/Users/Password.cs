public sealed record Password
{
    public string Value { get; init; }

    public Password(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException(nameof(value), "Password cannot be empty");
        }

        if (value.Length < 6)
        {
            throw new ArgumentException("Password cannot be less than 6 characters", nameof(value));
        }

        Value = value;
    }
}