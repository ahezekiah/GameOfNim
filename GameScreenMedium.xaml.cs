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

namespace GameOfNim
{
    /// <summary>
    /// Interaction logic for GameScreenMedium.xaml
    /// </summary>
    public partial class GameScreenMedium : Window
    {
        GameManager gm = new GameManager();

        public GameScreenMedium(GameManager gm)
        {
            InitializeComponent();
            this.gm = gm;
        }

        private void btnRowOne_Click(object sender, RoutedEventArgs e)
        {
            //Has 1 stone in the row
        }

        private void btnRowTwo_Click(object sender, RoutedEventArgs e)
        {
            //Has 3 stones in the row
        }

        private void btnRowThree_Click(object sender, RoutedEventArgs e)
        {
            //Has 5 stones in the row
        }

        private void btnRowFour_Click(object sender, RoutedEventArgs e)
        {
            //Has 7 stones in the row
        }

        private void btnEndTurn_Click(object sender, RoutedEventArgs e) 
        {
            //Becomes disabled when there are no more moves to make/when the game is over

        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            //Starts a new game OR resets the current game
        }

        private void btnReturnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
