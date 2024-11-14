/* Context class to hold all context relevant to a session.
 */

class Context {
  Space current;
  bool done = false;
  public Inventory PlayerInventory {get; set;}
  
  public Context (Space node) {
    current = node;
    PlayerInventory = new Inventory();
  }
  
  public Space GetCurrent() {
    return current;
  }
  
  public void Transition (string direction) {
    Space next = current.FollowEdge(direction);
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
}

