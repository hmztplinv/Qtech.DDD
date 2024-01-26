public sealed class Product: Entity // sealed bu sınıfın kalıtım alınmasını engeller , kullanma sebebi performans artışıdır.
{
    public Product(Guid id) : base(id)
    {
    }

    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public string Currency { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}
