/* Space class for modeling spaces (rooms, caves, ...)
 */

class Space(string name) : Node(name) {
    public void Welcome () {
    Console.WriteLine("You are now at "+name);
    HashSet<string> exits = edges.Keys.ToHashSet();
    Console.WriteLine("Current exits are:");
    foreach (string exit in exits) {
      Console.WriteLine(" - " + exit);
    }
  }
  
  public static void Goodbye () {
  }
  
  public override Space FollowEdge (string direction) {
    return (Space) base.FollowEdge(direction);
  }
}
