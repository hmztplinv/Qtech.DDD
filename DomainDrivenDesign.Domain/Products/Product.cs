public sealed class Product // sealed bu sınıfın kalıtım alınmasını engeller , kullanma sebebi performans artışıdır.
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public string Currency { get; set; }
    public Guid CategoryId { get; set; }
}
