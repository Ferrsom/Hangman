
namespace Hangman
{
    public class Model
    {

        List<string> wordsList = new List<string> { "baum", "tisch", "haus", "frau", "hund", "buch", "saft", "treppe", "flasche", "fenster" };

        //bool end = false;

        Random rnd = new Random();

        public string wordGoal()
        {
            string wordGoal = wordsList[rnd.Next(0, 10)];
            return wordGoal;
        }


    }
}
