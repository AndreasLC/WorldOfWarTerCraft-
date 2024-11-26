/* Command for exiting program */
class CommandExit : BaseCommand, ICommand {
  public CommandExit() {
    description ="Leave the game you will lose all your progress"; 
  }
  public void Execute (Context context, string command, string[] parameters) {
    context.MakeDone();
  }
}