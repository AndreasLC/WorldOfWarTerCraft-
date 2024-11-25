/* Main class for launching the game
 */

class Game {
  public static Context  ?context; 
  static World    ?world; 
  
  static ICommand fallback = new CommandUnknown();
  static Registry ?registry; 
  
  private static void InitRegistry () {
    ICommand cmdExit = new CommandExit();
    registry.Register("quit", cmdExit);
    registry.Register("go", new CommandGo());
    registry.Register("talk", new CommandTalk());
    registry.Register("help", new CommandHelp(registry));
    registry.Register("inventory", new CommandInventory()); 
    registry.Register("inv", new CommandInventory()); 
  }
  
  static void Main (string[] args) {
   context = new Context(null); 
   world = new World(context);
   context= new Context(world.GetBeach()); 
   registry = new Registry (context,fallback); 

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
