/* Space class for modeling spaces (rooms, caves, ...)
 */

class Space : Node {
//Constructor
  private Challenge challenge;
  private List<NPC> npcInSpace = new List<NPC>(); 
  public Space(string name) : base(name) {}

  public void AddNPC(NPC npc) {
      npcInSpace.Add(npc);
  }

  public void AddChallenge(Challenge challenge) {
      this.challenge = challenge;
  }

  public void ListNPCs() {
    if (npcInSpace.Count > 0) {
      Console.WriteLine("You see the following people here:");
        foreach (var npc in npcInSpace) {
        Console.WriteLine($" - {npc.GetNameNPC()}");
        }
    } 
      else {
            Console.WriteLine("There is no one here to talk to.");
        }
    }

  public void StartChallenge(Challenge challenge) {
    if (challenge != null) {
      Console.WriteLine("You have found a new challenge!");
      challenge.BeginChallenge(challenge);
    }
    else
      return;
    }

  private void DisplayExits() {
    HashSet<string> exits = edges.Keys.ToHashSet();
    Console.WriteLine("Current exits are:");
    foreach (string exit in exits) {
      Console.WriteLine($" - {exit}");
    }
  }


  public void EnterSpace() {
    Console.WriteLine($"You are now at {name}");
    DisplayExits();
    if (challenge != null) {
      StartChallenge(challenge);
      };
    ListNPCs();
  }
  
  public static void Goodbye () {
  }
  
  public override Space FollowEdge (string direction) {
    return (Space) base.FollowEdge(direction);
  }
}
