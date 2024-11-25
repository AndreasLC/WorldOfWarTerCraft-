/* Class for challenges */
class Challenge {

// Attributes
    private Question question;
    private Item item; 
    private Context context;

// Constructor
    // Adds a list of question
    public Challenge(Context context , Question question , Item item){
        this.context = context; 
        this.question = question;
        this.item = item; 
        
    }
    public void BeginChallenge(Challenge challenge) {
            bool answeredCorrectly = false; // Loops the method until answered correctly
            while(!answeredCorrectly && !context.IsDone()){
                question.QuestionDisplay();
                int inputUser = GetInputUser();
                if (question.IsCorrect(inputUser)){
                   
                    Console.WriteLine($"Your knowledge is increasing, you succesfully picked up the trash!");
                    Game.context.PlayerInventory.AddItem(item); // Adds rewarditem to inventory at game.context. 
                    Game.context.PlayerInventory.InventoryDisplay(); // shows inventory
                    Console.WriteLine();
                    answeredCorrectly = true; // Exits the loop when answered correctly
                    break;
                }
                else {
                    Console.WriteLine("Incorrect, try again!");
                      /* (Add a function here subtracting hp) */
                }
            } 
        
    }
    // Reads the input from user and checks for syntax errors
    private int GetInputUser(){
        int choice;
        while (true) {
            Console.WriteLine("Enter your answer(number between 1 and 5):");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out choice) && choice >= 1 && choice <= 5) {
                break;
            }
            else {
                Console.WriteLine("Try again, please enter a number between 1 and 5.");
            }
        }
        return choice;
    }
}