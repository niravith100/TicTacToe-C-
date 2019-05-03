using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class Main
    {
        Model model = new Model();
        Controller controller = new Controller(model);
        TicTacView view = new TicTacView(controller);
        //test
        
    }
}
