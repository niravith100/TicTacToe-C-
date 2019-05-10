namespace View
{
    public class Controller
    {
        private Model model;

        public Controller(Model model)
        {
            this.model = model;
        }

        public void makeMove(int pos)
        {
            model.MakeMove(pos);
        }
    }
}