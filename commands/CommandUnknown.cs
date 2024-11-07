/* Fallback for when a command is not implemented
 */

class CommandUnknown : BaseCommand, ICommand
{
    public void Execute(Context context, string command, string[] parameters)
    {
        Console.WriteLine("I don't understand '" + command + "', type 'help' for commands");
    }
}
