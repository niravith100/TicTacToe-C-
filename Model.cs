                 using System;

namespace View
{
    public class Model: Observable
    {
        int[] spelplan;
        int player = 1;
        int winner = 0;
        int rounds = 0;
        public bool start = false;
        

        public Model()
        {
            spelplan = new int[9];

        }

        public void MakeMove(int i)
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
                winner = 3;
            }
            
            CheckWinner();
            SetChanged();
            NotifyObservers();
        }

        public void CheckWinner()
        {
            for(int i = 0; i <= 2; i++)
            {
                // Vågrätt
                if (spelplan[0] == i && spelplan[1] == i && spelplan[2] == i)
                {
                    winner = i;
                }
                if (spelplan[3] == i && spelplan[4] == i && spelplan[5] == i)
                {
                    winner = i; 
                }
                if (spelplan[6] == i && spelplan[7] == i && spelplan[8] == i)
                {
                    winner = i;
                }

                // Lodrätt
                if (spelplan[0] == i && spelplan[3] == i && spelplan[6] == i)
                {
                    winner = i;
                }
                if (spelplan[1] == i && spelplan[4] == i && spelplan[7] == i)
                {
                    winner = i; 
                }
                if (spelplan[2] == i && spelplan[5] == i && spelplan[8] == i)
                {
                    winner = i;
                }

                //Diagonalt
                if (spelplan[0] == i && spelplan[4] == i && spelplan[8] == i)
                {
                    winner = i; 
                }
                if (spelplan[2] == i && spelplan[4] == i && spelplan[6] == i)
                {
                    winner = i;
                }
            }
        }

        public int [] GetSpelplan()
        {
            return spelplan;
        }

        public void RestartGame()
        {
            for(int i = 0; i < 9; i++)
            {
                spelplan[i] = 0;
            }
            rounds = 0;
            player = 1;
            winner = 0;
            SetChanged();
            NotifyObservers();
        }

        public int GetWinner()
        {
            return winner;
        }

        public bool GetStart()
        {
            return start;
        }

        public void SetStart(bool s)
        {
            start = s; 
        }
    } 
}