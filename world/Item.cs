public class Item {

// Atributes 
    private readonly string name;
    private readonly string description;
    private readonly int itemID;

// Constructor
    public Item(string name , string description , int itemID) {
        this.name = name;
        this.description = description; 
        this.itemID = itemID;
    }

// Methods 
    public string GetName() {
        return name; 
    }
    public int GetItemID() {
        return itemID; 
    }
    public string GetDescription() {
        return description;
    }

    // Displays items for inventory
    public override string ToString() {
        return $"{name} \t {description}";
    }
}
