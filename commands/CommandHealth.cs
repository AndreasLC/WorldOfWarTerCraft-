/* Command for displaying inventory */
class CommandHealth : BaseCommand, ICommand
{
    public CommandHealth() {
        description = "Display the player's health";
    }
    // Display health
    public void Execute(Context context, string command, string[] parameters) {
        Console.WriteLine($"You have a total of {context.PlayerHealth} lives");
    }
}