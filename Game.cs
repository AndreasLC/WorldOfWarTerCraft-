/* Main class for launching the game */

using System.Net;

class Game {
  public static Context ?context; 
  static World ?world; 
  
  static ICommand fallback = new CommandUnknown();
  static Registry ?registry; 
  
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
    int actionsCount = ConsoleReader.GetActionsCount(); // Initializes actionsCount
    int maxActions = 25; // Maximum allowed actions
    int actionsWarning = 10; // Warning amount

    context = new Context(null); 
    world = new World(context);
    context= new Context(world.GetBeach()); 
    registry = new Registry (context , fallback); 

    Console.WriteLine("Welcome to World of Trash!");
    Console.WriteLine();
    Console.WriteLine("You are the mighty sea turtle, your objective is to clean the plastic polluted sea and save the world!");
    Console.WriteLine($"As a sea turtle in these treacherous waters, you have been granted {maxActions} actions and {context.PlayerHealth} lives. Each wrong answer to a quiz will cost you a life."); 
    Console.WriteLine();
    InitRegistry();
    context.GetCurrent().EnterSpace();
    
    while (context.IsDone()==false && context.PlayerHealth>0) {
      Console.WriteLine(); 
      string? line = ConsoleReader.ReadLine();
      Console.WriteLine();
      line = line.ToLower(); // Converts input from user to lowercase
      if (line!=null) registry.Dispatch(line);
      // Gives the player a warning when actionsCount is actionsWarning amount from maxActions
      if (maxActions - actionsWarning == actionsCount) {
        Console.WriteLine();
        Console.WriteLine($"Time is running out, you have a total of {maxActions - actionsCount} actions left!");
      }
      // The player will die when reaching maxActions
      if (actionsCount == maxActions) {
        Console.WriteLine();
        Console.WriteLine("You used too many actions and got entangled in a fishing net...");
        break;
      }
      // The player completes the game when picking up the last item
      if (context.PlayerInventory.HasItem(10)) {
        Console.WriteLine();
        Console.WriteLine("Congratulations you have completed the game and saved the ocean!");
        Console.WriteLine($"You used a total of {actionsCount} actions throughout the game"); // Displays amount of actions used when completing the game
        return;
      }
    }
    Console.WriteLine("You died"); // Death message
  }
}