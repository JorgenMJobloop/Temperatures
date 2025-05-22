public class Store : IStore
{
    public string[]? TotalInventory;
    public string? ItemInInventory;
    public double OriginalPrice;

    // Constructor
    public Store(string[] totalInventory, string itemInInventory, double originalPrice)
    {
        TotalInventory = totalInventory;
        ItemInInventory = itemInInventory;
        OriginalPrice = originalPrice;
    }

    public double GetPercentage(double discountPrice)
    {
        double discountDollarAmout = OriginalPrice - discountPrice;
        double discountPercentageAmout = discountDollarAmout / OriginalPrice;
        return discountPercentageAmout;
    }

    public void PrintPriceReduction()
    {
        double priceReduction = GetPercentage(25); // cost: 10 USD
        Console.WriteLine($"{this.ItemInInventory} original price: {this.OriginalPrice}\nnew price: {priceReduction}");
    }

    public void PrintInventory()
    {
        Console.WriteLine($"Item in inventory: {this.ItemInInventory} with {this.TotalInventory!.Length} items.");
    }
}