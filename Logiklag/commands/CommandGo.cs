/* Command for transitioning between spaces */
class CommandGo : BaseCommand, ICommand {
  public CommandGo () {
    description = "Follow an exit";
  }
  
  public void Execute (Context context, string command, string[] parameters) {
  Space currentSpace = context.GetCurrent();
  try {
    if (GuardEq(parameters, 1)) {Console.WriteLine("Room doesn't exist...\n");
      currentSpace.EnterSpace();
      return;
    }
    context.Transition(parameters[0]);
  }
  catch (KeyNotFoundException) { // Prevents the user for crashing the game if correct input go is used but wrong direction. 
    Console.WriteLine("Wrong input try again\n");
    currentSpace.EnterSpace();
    }
  }
}
