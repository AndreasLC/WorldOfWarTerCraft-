/* Context class to hold all context relevant to a session */

class Context {
  Space current;
  bool done = false;
  public Inventory PlayerInventory;
  public int PlayerHealth{get;set;}  =3; 
  
  public Context (Space node) {
  current = node;
  PlayerInventory = new Inventory(new List<Item>()); // Starting with an empty inventory
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
  // Method for removing lifes in challenge.
   public void RemoveLifes()
    {
        PlayerHealth --; // Gets context player health wich is set to 3 and deducts 1 everytime it runs. 
        Console.WriteLine("you lost a life, you now have "+ PlayerHealth + " lives left!");  
        if(PlayerHealth <=0) // If lifes get to 0 call method MakeDone wich execute the game. 
        { 
        Console.WriteLine("womp womp you lost all your lives");
       }
    }


}


