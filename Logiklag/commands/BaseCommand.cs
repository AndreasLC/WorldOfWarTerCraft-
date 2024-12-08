// Baseclass for commands
class BaseCommand {
  protected string description = "Undocumented";
  
  protected static bool GuardEq (string[] parameters, int bound) {
    return parameters.Length!=bound;
  }
  
  public string GetDescription () {
    return description;
  }
}
