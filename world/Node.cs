/* Node class for modeling graphs
 */

class Node {
  protected string name;
  protected Dictionary<string, Node> edges = [];
  
  public Node (string name) {
    this.name = name;
  }
  
  public string GetName () {
    return name;
  }
  
  public void AddEdge (string name, Node node) {
    edges.Add(name, node);
  }
  
  public virtual Node FollowEdge (string direction) {
    return edges[direction];
  }
}

