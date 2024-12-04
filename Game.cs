/* Main class for launching the game */

class Game {
  public static Context? context; 
  static World? world; 
  
  static readonly ICommand fallback = new CommandUnknown();
  static Registry ?registry; 
  
  private static void InitRegistry () {
    ICommand cmdExit = new CommandExit();
    registry.Register("quit" , cmdExit);
    registry.Register("go" , new CommandGo());
    registry.Register("talk" , new CommandTalk());
    registry.Register("help" , new CommandHelp(registry));
    registry.Register("inventory", new CommandInventory()); 
    registry.Register("inv" , new CommandInventory()); 
    registry.Register("health" , new CommandHealth());
  }
  
  static void Main () {
    int maxActions = 60; // Maximum allowed actions, has to be >10
    int actionsWarning = maxActions - 10;
    context = new Context(null); 
    world = new World(context);
    context= new Context(world.GetRiver()); 
    registry = new Registry (context , fallback); 
    
    // Initialize blue background
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Clear();

    Console.WriteLine("Welcome to World of Trash!\n");
    Console.WriteLine("You are the mighty sea turtle, your objective is to clean the plastic polluted sea and save the world!");
    Console.WriteLine($"As a sea turtle in these treacherous waters, you have been granted a total of {maxActions} actions and {context.PlayerHealth} lives. Each wrong answer to a quiz will cost you a life.\n"); 
    InitRegistry();
    context.GetCurrent().EnterSpace();
    
    while (context.IsDone()==false && context.PlayerHealth>0) {
      int actionsCount = ConsoleReader.GetActionsCount(); // Initializes actionsCount
      Console.WriteLine(); 
      string? line = ConsoleReader.ReadLine();
      line = line.ToLower(); // Converts input from user to lowercase
      Console.Clear();
      if (actionsCount == actionsWarning) { // Gives the player a warning when actionsCount is actionsWarning amount from maxActions
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"Time is running out, you have a total of ({maxActions - actionsCount}) actions left!\n");
        Console.BackgroundColor = ConsoleColor.Blue;
      } else {
      Console.WriteLine($"You have currently used ({actionsCount}) actions\n"); // Displays actionsCount when player is alive
      }
      if (line!=null) registry.Dispatch(line);
      // The player will die when reaching maxActions
      if (actionsCount == maxActions) {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.Clear();
        Console.WriteLine("You used too many actions and got entangled in a fishing net...");
        break;
      }
    
        // The player completes the game when picking up the last item
      if (context.PlayerInventory.HasItem(10)) {
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.Clear();
        Console.WriteLine("Congratulations you have completed the game and saved the ocean!");
        Console.WriteLine($"You used a total of {actionsCount + 1} actions throughout the game"); // Displays amount of actions used when completing the game, with correction
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey(); // Wait for the user to press any key
        return;
      }
    }
    Console.WriteLine("You died"); // Death message
    Console.WriteLine("\nPress any key to exit...");
    Console.ReadKey(); // Wait for the user to press any key
  }
}