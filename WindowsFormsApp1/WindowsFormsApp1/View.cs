﻿using System;
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

        public View(Controller controller)
        {
            this.controller = controller;
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

        public void Update(object Model)
        {
            throw new NotImplementedException();
        }
    }
}