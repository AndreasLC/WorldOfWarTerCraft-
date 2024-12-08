class Space : Node {
  private Challenge? challenge;
  private readonly List<NPC> npcInSpace = []; 
  private readonly Dictionary<string, Item> requiredItems = [];

// Constructor for creating space without challenges and items.
  public Space(string name) : base(name){}
// Constructor for creating space with challenge.
  public Space (string name , Challenge challenge):base(name) {
    this.challenge = challenge; 
  }

// Methods
  // Adds NPCs to spaces
  public void AddNPC(NPC npc) {
      npcInSpace.Add(npc);
  }

  // Displays NPCs in space
  public void ListNPCs() {
    if (npcInSpace.Count > 0) {
      Console.WriteLine("You see the following people here:");
      foreach (var npc in npcInSpace) {
        Console.WriteLine($" - {npc.GetNameNPC()}");
        }
    }
  }
  public List<NPC> GetNPCs() {
    return npcInSpace;
  }

  // Starts challenges
  public static void StartChallenge(Challenge challenge) {
    if (challenge != null) {
      Console.WriteLine("You have found a new challenge!");
      challenge.BeginChallenge(challenge);
    }
    else
      return;
    }

  // Displays all exits in space
  private void DisplayExits() {
    HashSet<string> exits = edges.Keys.ToHashSet();
    Console.WriteLine("Current exits are:");
    foreach (string exit in exits) {
      Console.WriteLine($" - {exit}");
    }
  }

  public void EnterSpace() {
    Console.WriteLine($"You are now at {name}"); // Displays name of space
    while (challenge != null) { // Checks for challenges in space
      StartChallenge(challenge); // Starts challenge immediatly and has to be completed for method to continue
      challenge = null; // Removes challenge after completion 
      if (Game.context.PlayerHealth <= 0) {
        return;
      }
    };
    DisplayExits(); 
    ListNPCs();
  }
  
  // Adds an edge with an optional required item
  public void AddEdge(string direction, Space target, Item? requiredItem = null) {
    base.AddEdge(direction, target);
      if (requiredItem != null) {
        requiredItems[direction] = requiredItem;
      }
  }
  public override Node FollowEdge(string direction) {
    if (requiredItems.ContainsKey(direction)) {
      Item requiredItem = requiredItems[direction];
        if (!Game.context.PlayerInventory.HasItem(requiredItem.GetItemID())) {
          Console.WriteLine($"You need the {requiredItem.GetName()} to go {direction}.");
          return this;
        }
      }
    return base.FollowEdge(direction);
  }
  public static void Goodbye () {
  }
}