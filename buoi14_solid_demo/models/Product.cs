public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; }
    public string Description { get; set; } = string.Empty;

    public Product()
    {
        this.Id = 0;
        this.Name = string.Empty;
        this.Price = 0.0;
        this.Description = string.Empty;
    }

    public Product(int id, string name, double price, string description)
    {
        this.Id = id;
        this.Name = name;
        this.Price = price;
        this.Description = description;
    }
}