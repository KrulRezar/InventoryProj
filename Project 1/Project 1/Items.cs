public class Item
{
    // Properties with get/set
    public string Name { get; set; }
    public string Category { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    // Constructor Overloading (wala pa encapsulation)
    public Item(string name, int quantity, double price)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
        Category = "Uncategorized"; // Default category
    }

    public Item(string name, string category, int quantity, double price)
    {
        Name = name;
        Category = category;
        Quantity = quantity;
        Price = price;
    }
}
