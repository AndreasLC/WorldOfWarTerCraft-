class NPC {
// Attributes
    private readonly string nameNPC;
    private readonly string dialog;

// Constructor
    public NPC (string nameNPC, string dialog){
        this.nameNPC = nameNPC;
        this.dialog = dialog;
    }

// Methods
    public string GetNameNPC(){
        return nameNPC;
    }

    // Displays NPC dialog
    public void Talk() {
        Console.WriteLine($"I'm {nameNPC}! \n{dialog}");
    }
}