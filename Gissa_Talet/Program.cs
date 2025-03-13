namespace Gissa_Talet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Random object to generate a random number
            Random random = new Random();
            int answer = random.Next(0, 1000); // Generate a random number between 0 and 999
            int score = 0; // Initialize the attempt counter

            while (true) // Infinite loop to keep asking for guesses
            {
                Console.WriteLine("Gissa ett tal mellan 0 och 1000:"); // Prompt the user to guess a number

                string? text = Console.ReadLine(); // Read user input (nullable string)
                if (string.IsNullOrWhiteSpace(text)) // Check if input is null or empty
                {
                    Console.WriteLine("Ogiltig input! Vänligen ange ett nummer."); // Invalid input message
                    continue; // Restart loop
                }

                if (!int.TryParse(text, out int guess)) // Try to convert input to an integer
                {
                    Console.WriteLine("Ogiltig input! Vänligen ange ett giltigt nummer."); // Invalid number message
                    continue; // Restart loop
                }

                score++; // Increment the attempt counter

                if (guess == answer) // Check if the guess is correct
                {
                    Console.WriteLine($"Rätt svar! Du gissade rätt på {score} försök."); // Correct guess message
                    break; // Exit loop
                }
                else if (guess < answer) // Check if the guess is too low
                {
                    Console.WriteLine("För lågt! Försök igen."); // Hint for a low guess
                }
                else // The guess is too high
                {
                    Console.WriteLine("För högt! Försök igen."); // Hint for a high guess
                }
            }
        }
    }
}
