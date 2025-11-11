
namespace Hangman
{
    public class View
    {
        public void Greeting()
        {
            Console.WriteLine("Welcome to Hangman! Guess the word:");
        }

        public void Blended(string wordGoal)
        {
            for (int i = 0; i < wordGoal.Length; i++)
            {
                Console.Write("_ ");
            }
            Console.WriteLine("");
        }

        public char PlayerGuess()
        {
            Console.WriteLine("Give a letter:");
            int input = Console.Read();
            char letter = (char)input;
            return letter;
        }

        public void Check(string wordGoal, char letter)
        {
            for (int i = 0; i < wordGoal.Length; i++)
            {
                if (wordGoal[i] == letter)
                {
                    Console.Write(letter + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }
        }

    }
}
