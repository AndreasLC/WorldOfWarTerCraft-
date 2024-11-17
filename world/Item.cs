public class Item {

// Atributes 
    private string name;
    private string description;
    private int itemID;

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
