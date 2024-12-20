/* Command for displaying inventory */
class CommandInventory : BaseCommand, ICommand
{
    public CommandInventory() {
        description = "Display the player's inventory";
    }
    // Display inventory
    public void Execute(Context context, string command, string[] parameters) {
        Space currentSpace = context.GetCurrent();
        Inventory inventory = context.PlayerInventory; // Calls inventory in Game.context 

        inventory.InventoryDisplay();
        currentSpace.EnterSpace();
    }
}