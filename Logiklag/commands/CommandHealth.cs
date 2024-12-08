/* Command for displaying health */
class CommandHealth : BaseCommand, ICommand
{
    public CommandHealth() {
        description = "Display the player's health";
    }
    // Display health
    public void Execute(Context context, string command, string[] parameters) {
        Space currentSpace = context.GetCurrent();

        Console.WriteLine($"You have a total of {context.PlayerHealth} lives\n");
        currentSpace.EnterSpace();
    }
}