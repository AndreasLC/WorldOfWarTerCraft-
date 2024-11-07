/* Command for transitioning between spaces
 */

class CommandGo : BaseCommand, ICommand {
  public CommandGo () {
    description = "Follow an exit";
  }
  
  public void Execute (Context context, string command, string[] parameters) {
 try {
    if (GuardEq(parameters, 1)) {
      Console.WriteLine("Room doesn't exist");
      return;
    }
    context.Transition(parameters[0]);
     }
     catch (KeyNotFoundException) {Console.WriteLine("Wrong input try again");}
  }
}
