public class Inventory {
// Constructor 
    private List<Item> items = new List<Item>();

// Methods
    // Display inventory
    public void InventoryDisplay()
    {        
    Console.WriteLine("Inventory:");
    Console.WriteLine("Name \t\t" + "| " + "Description");
    Console.WriteLine(new string('-', 16) + "┴" + new string('-', 79));
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
        if (!items.Any()) // Checks for items in inventory
        {
            Console.WriteLine("Inventory was empty");
        }
        Console.WriteLine();  
    }

    // Adds new item to inventory
    public void AddItem (Item newItem) 
    {   
        // If items list doesn't contain newItem, add to inventory and display message
        if (newItem != null && !items.Contains(newItem)) {
            items.Add(newItem);
            Console.WriteLine($"Congratulations! {newItem.GetName()} has been added to your inventory.");

        }
    }

    // Checks if player has the item
    public bool HasItem(int keyNumber) {
        return items.Any(item => item.GetItemID() == keyNumber);
        } 
}