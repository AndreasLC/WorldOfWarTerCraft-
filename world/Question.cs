public class Question {
//Attributes
    public string text {get; set; }
    public string[] choices {get; set; }
    public int correctAnswer {get; set; }


//Constructor
    public Question(string text, string[] choices, int correctAnswer) {
        this.text = text;
        this.choices = choices;
        this.correctAnswer = correctAnswer;
    }

//Methods
    public void QuestionDisplay() {
        Console.WriteLine(text);
        for (int i = 0; i < choices.Length; i++) {
            Console.WriteLine($"{i + 1}. {choices[i]}");
        }
    }

    public bool IsCorrect(int choice) {
        return choice == correctAnswer;
    }
}