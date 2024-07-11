using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace GameOfNim
{
    /// <summary>
    /// Interaction logic for WinScreenP1Easy.xaml
    /// </summary>
    public partial class WinScreen : Window
    {
        MenuScreen main = new MenuScreen();

        public WinScreen()
        {
            InitializeComponent();
        }

        public void Setup(string p1Name, string p2Name, string dif, bool p1Win)
        {
            P1NameLabel.Content = "Player 1: " + p1Name;
            P2NameLabel.Content = "Player 2: " + p2Name;
            DifLabel.Content = "Difficulty: " + dif;
            if (p1Win)
            {
                WinLabel.Content = p1Name + " wins! Play again?";
            }
            else
            {
                WinLabel.Content = p2Name + " wins! Play again?";
            }
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            main.Show();
            this.Close();
        }

        private void btnCloseGame_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
