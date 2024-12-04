/* Help command */

class CommandHelp : BaseCommand, ICommand {
    readonly Registry registry;
  
  public CommandHelp (Registry registry) {
    this.registry = registry;
    description = "Display a help message";
  }
  
  public void Execute (Context context, string command, string[] parameters) {
    Space currentSpace = context.GetCurrent();
    string[] commandNames = registry.GetCommandNames();
    Array.Sort(commandNames);
    
    // Find max length of command name
    int max = 0;
    foreach (string commandName in commandNames) {
      int length = commandName.Length;
      if (length>max) max = length;
    }
    
    // Present list of commands
    Console.WriteLine("Commands:");
    foreach (string commandName in commandNames) {
      string description = registry.GetCommand(commandName).GetDescription();
      Console.WriteLine(" - {0,-"+max+"} "+description, commandName);
    }
    Console.WriteLine();
    currentSpace.EnterSpace();
  }
}
