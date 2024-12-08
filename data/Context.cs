/* Context class to hold all context relevant to a session */

class Context {
  Space current;
  bool done = false;
  public Inventory PlayerInventory;
  public int PlayerHealth{get;set;}  =  3; 
  
  public Context (Space node) {
    current = node;
    PlayerInventory = new([]); // Starting with an empty inventory
  }
  
  public Space GetCurrent() {
    return current;
  }
  
  public void Transition (string direction) {
    Space next = (Space)current.FollowEdge(direction);
    if (next==null) {
      Console.WriteLine($"You are confused, and walk in a circle looking for '{direction}'. In the end you gave up :(");
    } else {
      Space.Goodbye();
      current = next;
      current.EnterSpace();
    }
  }
  
  public void MakeDone () {
    done = true;
  }
  
  public bool IsDone () {
    return done;
  }
  // Method for removing lives in challenge.
  public void RemoveLifes() {
    PlayerHealth --; // Gets context player health which is set to 3 and deducts 1 everytime it runs. 
    if(PlayerHealth <=0) { // If lives get to 0 set the commandbackground color to red indicating that you lost the game.  
      Console.BackgroundColor = ConsoleColor.DarkRed;
      Console.Clear();
      Console.WriteLine("You lost all your lives, better luck next time! :)");
      return;
    }
    Console.WriteLine($"You lost a life, you now have {PlayerHealth} lives left!");  
  }
}