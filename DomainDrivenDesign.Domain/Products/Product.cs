public sealed class Product: Entity // sealed bu sınıfın kalıtım alınmasını engeller , kullanma sebebi performans artışıdır.
{
    public Product(Guid id,Name name, int quantity, Money price, Guid categoryId, Category category): base(id)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
        CategoryId = categoryId;
        Category = category;
    }

    public Name Name { get; private set; }
    public int Quantity { get; private set; }
    public Money Price { get; private set; }
    public Guid CategoryId { get; private set; }
    public Category Category { get; private set; }

    public void Update(string name,decimal amount,string currency,int quantity,Guid categoryId)
    {
        Name = new(name);
        Price = new(amount,Currency.FromCode(currency));
        Quantity = quantity;
        CategoryId = categoryId;
    }
}
