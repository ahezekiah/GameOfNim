using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GameOfNim
{
    public class GameManager
    {
        public bool IsGameOver { get; set; } = false;
        public GameManager() { }

        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public bool IsPlayer1 { get; set; } = true;
        public bool IsGameOver { get; set; } = false;
        public List<List<Image>> Rows { get; set; }

        public GameManager(string p1Name, string p2Name) 
        {
            PlayerOne = new Player(p1Name);
            PlayerTwo = new Player(p2Name);
        }

        public void Start()
        {
            // Start of game loop


            while (!IsGameOver)
            {

            }
        }

        private void Easy()
        {
            // number of lists
        }

        private void Medium()
        {
            // number of lists
        }

        private void Hard()
        {
            // number of lists
        }

        private void SwapPlayer()
        {
            IsPlayer1 = !IsPlayer1;
        }

        private bool CheckWin()
        {
            return false;
        }
    }
}
