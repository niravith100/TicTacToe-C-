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
            /*if(textBoxPlayer1.TextChanged = true)
            {
                player1 = textBoxPlayer1.Text;
            }
            player1 = textBoxPlayer1.TextChanged.Text;
            player1 = textBoxPlayer2.Text;
           **/
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
                    TurnLable.Text = "It's " + player1 + "turn";
                    SpelKnapp[i].Enabled = false;
                }

                else if (SpelPlan[i] == 2)
                {
                    SpelKnapp[i].Text = "O";
                    TurnLable.Text = "It's " + player2 + "turn";
                    SpelKnapp[i].Enabled = false;
                }

                else if (SpelPlan[i] == 0)
                {
                    SpelKnapp[i].Text = " ";
                   
                }

            }
            int winner = model.GetWinner();
            if (winner == 1)
            {
                String message = "Play1 =" + player1 + "Won! Do you want to restart the game?";
                String title = "Restart";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    model.RestartGame();
                    for (int j = 0; j < 9; j++)
                    {
                        SpelKnapp[j].Text = " ";
                        SpelKnapp[j].Enabled = true;
                    }
                }
                else
                {
                    // Do nothing
                }
            }

            if (winner == 2)
            {

                String message = " player2 = " + player2 + "Won! Do you want to restart the game?";
                String title = "Restart";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    model.RestartGame();
                    for (int j = 0; j < 9; j++)
                    {
                        SpelKnapp[j].Text = " ";
                        SpelKnapp[j].Enabled = true;
                    }
                }
                else
                {
                    // Do nothing
                }
            }


            else if (winner == 3)
            {
                String message ="It's a Draw! Do you want to restart the game?";
                String title = "Restart";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    model.RestartGame();
                    for (int j = 0; j < 9; j++)
                    {
                        SpelKnapp[j].Text = " ";
                        SpelKnapp[j].Enabled = true;
                    }
                }
            }
            


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void RestartButton_Click(object sender, object Model,  EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPlayer1_TextChanged(object sender, EventArgs e)
        {
            player1 = textBoxPlayer1.Text+ " ";
        }

        private void textBoxPlayer2_TextChanged(object sender, EventArgs e)
        {
            player2 = textBoxPlayer2.Text + " ";
        }

        private void TurnLable_Click(object sender, EventArgs e)
        {

        }
    }
}
