
namespace Hangman
{
    public class Controller
    {
        private Model model;
        private View view;

        public Controller(Model model, View view)
        {
            this.model = model;
            this.view = view;
        }

        public void Start()
        {
            //bool end = false;

            view.Greeting();
            var goal = model.wordGoal();
            view.Blended(goal);


            var letter = view.PlayerGuess();
            view.Check(goal, letter);


        }
    }
}
