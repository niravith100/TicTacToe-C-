                 using System;

namespace View
{
    public class Model: Observable
    {
        int[] spelplan;
        int player = 1;
        int winner = 0;
        int rounds = 0; 
         

        public Model()
        {
            spelplan = new int[9];

        }

        public void makeMove(int i)
        {
            spelplan[i] = player;

            if (player == 1)
            {
                player = 2;
            }

            else if (player == 2)
            {
                player = 1;
            }

            rounds++;
            if(rounds  == 9 && winner == 0)
            {
                winner = -1;
            }

            //checkWinner();
            SetChanged();
            NotifyObservers();
        }

    }
}