public sealed record Currency
{
    internal static readonly Currency Default = new("");
    public static readonly Currency TL = new("TL");
    public static readonly Currency USD = new("USD");
    public string Code { get; init; }

    private Currency(string code)
    {
        Code = code;
    }

    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(x => x.Code == code) ?? throw new ArgumentException($"Currency code {code} is not supported");
    }

    public static readonly IReadOnlyCollection<Currency> All = new[]
    {
        TL,
        USD
    };
}