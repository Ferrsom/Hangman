
namespace Hangman
{
    public class Controller
    {
        Model model;
        View view;

        public Controller(Model model, View view)
        {
            this.model = model;
            this.view = view;
        }

        public void Start()
        {

            view.Greeting();
            var goal = model.wordGoal();
            view.Blended(goal);
            var letter = view.PlayerGuess();
            model.addLetter(letter);
            view.Check(goal,letter);

           
        }
    }
}
