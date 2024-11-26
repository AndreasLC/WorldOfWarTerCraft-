
public class Inventory {
// Atriburtes
private List<Item> items;

// Constructor
public Inventory (List<Item> items)
{
    this.items = items; 
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

// Methods
    // Display inventory
    public void InventoryDisplay()
    {        
        Console.WriteLine("Inventory:");
        Console.WriteLine("Name \t\t" + "| " + "Description");
        Console.WriteLine(new string('-', 16) + "┴" + new string('-', 79));
        if (items.Any()) { 
            foreach (var item in items)
            Console.WriteLine(item);
        } else {
            Console.WriteLine("Inventory was empty");
        }
            Console.WriteLine();  
    }

    // Checks if player has the item
    public bool HasItem(int keyNumber) {
        return items.Any(item => item.GetItemID() == keyNumber);
    }
}