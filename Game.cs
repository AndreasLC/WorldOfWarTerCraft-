/* Main class for launching the game
 */

class Game {
  static World    world    = new World();
  static Context  context  = new Context(world.GetBeach());
  static ICommand fallback = new CommandUnknown();
  static Registry registry = new Registry(context, fallback);
  
  private static void InitRegistry () {
    ICommand cmdExit = new CommandExit();
    registry.Register("exit", cmdExit);
    registry.Register("quit", cmdExit);
    registry.Register("bye", cmdExit);
    registry.Register("kill", cmdExit);
    registry.Register("go", new CommandGo());
    //registry.Register("talk", new CommandNPC());
    registry.Register("help", new CommandHelp(registry));
    registry.Register("inventory", new CommandInventory()); 
    registry.Register("inv", new CommandInventory()); 
  }
  
  static void Main (string[] args) {
   Console.WriteLine("Welcome to World of Trash!");
   Console.WriteLine();
   Console.WriteLine("You are the mighty sea turtle, your objective is to clean the plastic polluted sea and save the world!");
   Console.WriteLine();
    InitRegistry();
    context.GetCurrent().EnterSpace();
    
    while (context.IsDone()==false) {
      Console.WriteLine();
      string? line = Console.ReadLine();
      Console.WriteLine();
      // Converts input from user to lowercase:)
      line = line.ToLower();
      if (line!=null) registry.Dispatch(line);
    }
    Console.WriteLine("You died");
  }
}
