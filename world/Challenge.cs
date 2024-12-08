/* Class for challenges */
class Challenge {

// Attributes
    private readonly Question question;
    private readonly Item item; 
    private readonly Context context;

// Constructor
    // Adds a list of question
    public Challenge(Context context , Question question , Item item) {
        this.context = context; 
        this.question = question;
        this.item = item; 
    }
    public void BeginChallenge(Challenge challenge) {
        Inventory inventory = Game.context.PlayerInventory;
        bool answeredCorrectly = false; // Loops the method until answered correctly
        while(!answeredCorrectly) {
            question.QuestionDisplay();
            int inputUser = GetInputUser();
            if (question.IsCorrect(inputUser)) {
                Console.WriteLine($"Your knowledge is increasing, you succesfully picked up the trash!");
                inventory.AddItem(item); // Adds rewarditem to inventory at game.context. 
                inventory.InventoryDisplay(); // shows inventory
                Console.WriteLine($"You now have {Game.context.PlayerHealth} lives left!");
                Console.WriteLine();
                answeredCorrectly = true; // Exits the loop when answered correctly
            } else {
                Console.Clear();
                Game.context.RemoveLifes(); // Function removes 1 life from player
                if (Game.context.PlayerHealth >= 1) {
                    Console.WriteLine("Incorrect, try again!");
                } else {
                    return; 
                }
            }
        } 
        
    }
    // Reads the input from user and checks for syntax errors
    private static int GetInputUser() {
        int choice;
        while (true) {
            Console.WriteLine();
            Console.WriteLine("Enter your answer: (Choose number between 1 and 4)");
            string? input = ConsoleReader.ReadLine();
            if (int.TryParse(input, out choice) && choice >= 1 && choice <= 4) {
                break;
            } else {
                Console.WriteLine("Try again, please enter a number between 1 and 4.");
            }
        }
        return choice;
    }
}