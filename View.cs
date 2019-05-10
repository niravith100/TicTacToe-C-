using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class View : Form, IObserver
    {
        private Controller Controller;
        private string player1;
        private string player2;
        Button[] SpelKnapp;

        public View(Controller controller)
        {
            InitializeComponent();
            Controller = controller;
            SpelKnapp = new Button[9];
            SpelKnapp[0] = SpelKnapp1;
            SpelKnapp[1] = SpelKnapp2;
            SpelKnapp[2] = SpelKnapp3;
            SpelKnapp[3] = SpelKnapp4;
            SpelKnapp[4] = SpelKnapp5;
            SpelKnapp[5] = SpelKnapp6;
            SpelKnapp[6] = SpelKnapp7;
            SpelKnapp[7] = SpelKnapp8;
            SpelKnapp[8] = SpelKnapp9;
        }

      public View()
        {
          InitializeComponent();
       }

        private void spelknapp_Click(object sender, EventArgs e)
        {
            string command = ((Button)sender).Tag.ToString();
            Controller.makeMove(int.Parse(command));
        }

        void IObserver.Update(object Model)
        {
            Model model = (Model)Model;
            int[] SpelPlan = model.GetSpelplan();

            for (int i = 0; i < 9; i++)
            {
                if (SpelPlan[i] == 1)
                {
                    SpelKnapp[i].Text = "X";
                    TurnLable.Text = "It's" + player1 + "turn";
                    SpelKnapp[i].Enabled = false;
                }

                else if (SpelPlan[i] == 2)
                {
                    SpelKnapp[i].Text = "O";
                    TurnLable.Text = "It's" + player2 + "turn";
                    SpelKnapp[i].Enabled = false;
                }

                else if (SpelPlan[i] == 0)
                {
                    SpelKnapp[i].Text = " ";
                    //SpelKnapp[i].Enabled = false;
                }

            }
            int winner = model.GetWinner();
            if (winner == 1)
            {
                
                TurnLable.Text = player1 + "Won";
                model.RestartGame();
            }

            else if(winner == 2)
            {
                TurnLable.Text = player2 + "Won";
                model.RestartGame();
            }

            else if(winner == 3)
            {
                TurnLable.Text = "Draw!";
                model.RestartGame();
            }

            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
