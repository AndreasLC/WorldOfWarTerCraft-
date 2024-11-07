using System.Security.Cryptography;

public class Inventory 
{
// Atributes 
    private Item[] Items;
// Constructor 
public Inventory (Item[] Items) 
{
    this.Items = Items;
}
static string PrintDashes(int length)
    {
        return new string('-', length);
    }

    // Inventory display
    public void InventoryDisplay()
    {        
    Console.WriteLine("Inventory:");
        for (int i = 0; i < Items.Length; i++)
        {
            // Makes sure it only prints Item in inventory if there are any.
            if (Items[i] != null)
            {
                Console.WriteLine("Inventory:");
                Console.WriteLine("Name \t\t Effect \t Description");
                Console.WriteLine(PrintDashes(44));
                Console.WriteLine(Items[i]);
            }
            else if (Items[i]==null) 
            {
                Console.WriteLine("Inventory was empty");
                break; 
            }
        }
        Console.WriteLine();  
    }

public void AddItem (Item NewItem) 
{
    for (int i = 0 ; i< Items.Length;i++)
    {
        
            // Checks if there is place for a new item
            if(Items[i]==null)
            {
                Items[i] = NewItem;
                break; 
            }
        
    }
}
public bool HasItem(int keyNumber)
{
    foreach (Item item in Items)
    {
        if (item != null && item.GetID() == keyNumber)
        {
            return true;
        }
    } 
    return false; 
}

}