public static class ConsoleReader {
// Attributes
    private static int readLineCount = 1;

// Methods
    public static string? ReadLine() {
        readLineCount++; // Adds 1 to the counter each time ReadLine() is used 
        return Console.ReadLine();
    }

    // Returns the readLineCount value
    public static int GetActionsCount() {
        return readLineCount; 
    }
}