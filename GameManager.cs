using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GameOfNim
{
    public enum DifficultyType
    {
        EASY,
        MEDIUM,
        HARD
    }

    public class GameManager
    {
        public GameManager() { }

        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public bool IsPlayer1 { get; set; } = true;
        public DifficultyType DiffType { get; set; }
        public List<int> Rows { get; set; }
        public int rowChosen { get; set; } = -1;

        public GameManager(string p1Name, string p2Name) 
        {
            PlayerOne = new Player(p1Name);
            PlayerTwo = new Player(p2Name);
        }

        public void Easy()
        {
            Rows.Clear();

            // number of lists
            Rows.Add(1);
            Rows.Add(3);
            Rows.Add(5);
        }

        public void Medium()
        {
            Rows.Clear();

            // number of lists
            Rows.Add(1);
            Rows.Add(3);
            Rows.Add(5);
            Rows.Add(7);
        }

        public void Hard()
        {
            Rows.Clear();

            // number of lists
            Rows.Add(3);
            Rows.Add(5);
            Rows.Add(7);
            Rows.Add(9);
            Rows.Add(11);
        }

        public bool Subtract(int row)
        {
            if (Rows[row] <= 0 || row != rowChosen)
            {
                return false;
            }
            else
            {
                rowChosen = row;
                Rows[row]--;
                return true;
            }
        }

        private void SwapPlayer()
        {
            IsPlayer1 = !IsPlayer1;
        }

        public bool CheckWin()
        {
            int totalStones = 0;
            for (int i = 0; i < Rows.Count; i++)
            {
                totalStones += Rows[i];
            }

            if (totalStones <= 0)
            {
                return true;
            }
            SwapPlayer();
            return false;
        }
    }
}
