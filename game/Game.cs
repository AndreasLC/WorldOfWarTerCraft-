/* Main class for launching the game
 */

class Game {
  public static Context? context; 
  static World? world; 
  
  static ICommand fallback = new CommandUnknown();
  static Registry? registry; 
  
  private static void InitRegistry () {
    ICommand cmdExit = new CommandExit();
    registry.Register("quit" , cmdExit);
    registry.Register("go" , new CommandGo());
    registry.Register("talk" , new CommandTalk());
    registry.Register("help" , new CommandHelp(registry));
    registry.Register("inventory" , new CommandInventory()); 
    registry.Register("inv" , new CommandInventory()); 
    registry.Register("health" , new CommandHealth());
  }
  
  static void Main (string[] args) {
    context = new Context(null); 
    world = new World(context);
    context= new Context(world.GetBeach()); 
    registry = new Registry (context , fallback); 

    Console.WriteLine("Welcome to World of Trash!");
    Console.WriteLine();
    Console.WriteLine("You are the mighty sea turtle, your objective is to clean the plastic polluted sea and save the world!");
    Console.WriteLine($"As a sea turtle in these treacherous waters, you have been granted {context.PlayerHealth} lives. Each wrong answer to a quiz will cost you a life."); 
    Console.WriteLine();
    
    while (context.IsDone()==false && context.PlayerHealth > 0) {
      InitRegistry();
      context.GetCurrent().EnterSpace();
      Console.WriteLine(); 
      string? line = Console.ReadLine();
      Console.WriteLine();
      // Converts input from user to lowercase:)
      line = line.ToLower();
      if (line!=null) registry.Dispatch(line);
      if (context.PlayerInventory.HasItem(10)) {
        Console.WriteLine("Congrats you beat the game and cleaned up the beach!");
      return; // Returns to stop the game after collecting the last item
    }
    }
    Console.WriteLine("You died");
  }
}