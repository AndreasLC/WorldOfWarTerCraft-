public class Question {
//Attributes
    public string Text {get; set; }
    public string[] Choices {get; set; }
    public int CorrectAnswer {get; set; }


//Constructor
    public Question(string text, string[] choices, int correctAnswer) {
        Text = text;
        Choices = choices;
        CorrectAnswer = correctAnswer;
    }

//Methods
    // Displays questions for challenges
    public void QuestionDisplay() {
        Console.WriteLine(Text);
        for (int i = 0; i < Choices.Length; i++) {
            Console.WriteLine($"{i + 1}. {Choices[i]}");
        }
    }

    // Checks for correct answer
    public bool IsCorrect(int choice) {
        return choice == CorrectAnswer;
    }
}