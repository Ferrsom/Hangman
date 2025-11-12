
namespace Hangman
{
    public class Model
    {

        List<string> wordsList = new List<string> { "baum", "tisch", "haus", "frau", "hund", "buch", "saft", "treppe", "flasche", "fenster" };

        List<char> lettersList = new List<char> { };

        Random rnd = new Random();

        public string wordGoal()
        {
            string wordGoal = wordsList[rnd.Next(0, 10)];
            return wordGoal;
        }

        public void addLetter(char letter)
        {
            lettersList.Add(letter);
        }

    }
}
