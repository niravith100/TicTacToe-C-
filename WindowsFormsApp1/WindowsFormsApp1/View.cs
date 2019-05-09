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
    public partial class View : Form, IObservable
    {
        private Controller controller;
        private string player1;
        private string player2;
        Button[] SpelKnapp;

        public View(Controller controller)
        {
            this.controller = controller;
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
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TicTacToe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void TurnLable_Click(object sender, EventArgs e)
        {

        }

        private void SpelKnapp1_Click(object sender, EventArgs e)
        {

        }

        private void SpelPlanNedreDel_Load(object sender, EventArgs e)
        {

        }

        private void SpelKnapp4_Click(object sender, EventArgs e)
        {

        }

        public void Update(object arg0, Object arg1)
        {
            Model model = (Model) arg0;
            int[] SpelPlan = model.GetSpelplan();
          
            for(int i = 0; i <9; i++)
            {
                if (SpelPlan[i] == 1)
                {
                    SpelKnapp[i].Text = "X";
                    TurnLable.Text = "It's" + player1 + "turn";
                    SpelKnapp[i].Enabled = false;
                }

                else if(SpelPlan[i] == 2)
                {
                    SpelKnapp[i].Text = "O";
                    TurnLable.Text = "It's" + player2 + "turn";
                    SpelKnapp[i].Enabled = false;
                }

                else if(SpelPlan[i] == 0)
                {
                    SpelKnapp[i].Text = " ";
                    SpelKnapp[i].Enabled = false;
                }

            }
            
        }

        private void SpelKnapp9_Click(object sender, EventArgs e)
        {

        }
    }
}
