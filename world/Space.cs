/* Space class for modeling spaces, challenges and npcs */

class Space : Node {
// Constructor
  private Challenge challenge;
  private List<NPC> npcInSpace = new List<NPC>(); 

// Constructor
  public Space(string name) : base(name) {}

// Methods
  // Adds NPCs to spaces
  public void AddNPC(NPC npc) {
      npcInSpace.Add(npc);
  }

  // Adds challenges to spaces
  public void AddChallenge(Challenge challenge) {
      this.challenge = challenge;
  }

  // Displays NPCs in space
  public void ListNPCs() {
    if (npcInSpace.Count > 0) {
      Console.WriteLine("You see the following people here:");
        foreach (var npc in npcInSpace) {
        Console.WriteLine($" - {npc.GetNameNPC()}"); // Example (" - testNPC")
        }
    } 
      else {
            Console.WriteLine("There is no one here to talk to.");
        }
    }
    public List<NPC> GetNPCs()
    {
      return npcInSpace;
    }

  // Starts challenges
  public void StartChallenge(Challenge challenge) {
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
    };
    DisplayExits(); 
    ListNPCs();
  }
  
  public static void Goodbye () {
  }
  
  // Go to new space
  public override Space FollowEdge (string direction) {
    return (Space) base.FollowEdge(direction);
  }
}
