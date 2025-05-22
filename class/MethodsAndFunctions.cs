using System.Linq;
public class MethodsAndFunctions
{
    public List<string>? ShoppingListItems;


    public MethodsAndFunctions(List<string> items)
    {
        ShoppingListItems = items;
    }

    public void PrintAllItemsInList()
    {
        foreach (string items in ShoppingListItems!)
        {
            Console.WriteLine(items);
        }
    }

    public void UseLambdaExpression()
    {
        var search = ShoppingListItems!.BinarySearch("item5");
        Console.WriteLine(search);
    }

}