/* Command for transitioning between spaces */
class CommandGo : BaseCommand, ICommand {
  public CommandGo () {
    description = "Follow an exit";
  }
  
  public void Execute (Context context, string command, string[] parameters) {
  Space currentSpace = context.GetCurrent();
  try {
    if (GuardEq(parameters, 1)) {Console.WriteLine("Room doesn't exist...");
      Console.WriteLine();
      currentSpace.EnterSpace();
      return;
    }
    context.Transition(parameters[0]);
  }
  catch (KeyNotFoundException) {
    Console.WriteLine("Wrong input try again");
    Console.WriteLine();
    currentSpace.EnterSpace();
    }
  }
}
