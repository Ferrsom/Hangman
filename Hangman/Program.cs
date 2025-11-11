
namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new Model();
            var view = new View();
            var controller = new Controller(model, view);

            controller.Start();
        }
    }
}
