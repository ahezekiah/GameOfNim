using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNim
{
    public class GameManager
    {
        public Player? PlayerOne { get; set; } = null;
        public Player? PlayerTwo { get; set; } = null;
        public bool IsPlayerOne { get; set; } = true;
        public bool IsGameOver { get; set; } = false;
        public GameManager() { }

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

        private void SwitchPlayer()
        {

        }

        private bool CheckWin()
        {


            return false;
        }
    }
}
