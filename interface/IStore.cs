public interface IStore
{

    /// <summary>
    /// Get the percentage on any item that has a discount in our stores inventory system
    /// </summary>
    /// <param name="discountPrice">the discount price on our item</param>
    /// <returns>new discount price for items</returns>
    double GetPercentage(double discountPrice);

    /// <summary>
    /// Prints the price reduction for our items
    /// </summary>
    void PrintPriceReduction();
    /// <summary>
    /// Prints the total amout of items in our inventory
    /// </summary>
    void PrintInventory();

}