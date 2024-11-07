class CommandInventory : BaseCommand, ICommand
{
    public CommandInventory() {
        description = "Display the player's inventory";
    }
    //Display inventory
    public void Execute(Context context, string command, string[] parameters)
    {
    //Creates inventory array
    Item[] Items = new Item[9];
    
    Inventory inventory = new (Items);

    inventory.InventoryDisplay(); 
    }
}