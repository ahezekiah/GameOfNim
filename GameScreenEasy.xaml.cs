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
    /// Interaction logic for GameScreenEasy.xaml
    /// </summary>
    public partial class GameScreenEasy : Window
    {
        public GameManager gm;
        private List<Image> Row1 = new List<Image>();
        private List<Image> Row2 = new List<Image>();
        private List<Image> Row3 = new List<Image>();
        bool played = false;

        public GameScreenEasy(GameManager gm)
        {
            InitializeComponent();
            Row1.Add(Stone1);
            Row2.Add(Stone2);
            Row2.Add(Stone3);
            Row2.Add(Stone4);
            Row3.Add(Stone5);
            Row3.Add(Stone6);
            Row3.Add(Stone7);
            Row3.Add(Stone8);
            Row3.Add(Stone9);
            this.gm = gm;
            SetupGame();
        }

        private void SetupGame()
        {
            P1Name.Content = "Player 1: " + gm.PlayerOne.Name;
            P2Name.Content = "Player 2: " + gm.PlayerTwo.Name;
            gm.Easy();
            for (int i = Row1.Count - 1; i >= 0; i--)
            {
                Row1[i].Visibility = Visibility.Visible;
            }
            for (int i = Row1.Count - 1; i >= 0; i--)
            {
                Row2[i].Visibility = Visibility.Visible;
            }
            for (int i = Row3.Count - 1; i >= 0; i--)
            {
                Row3[i].Visibility = Visibility.Visible;
            }
        }

        private void btnRowOne_Click(object sender, RoutedEventArgs e)
        {
            //Has 1 stone in the row
            if (gm.Subtract(1))
            {
                for (int i = Row1.Count - 1; i >= 0; i--)
                {
                    if (Row1[i].Visibility != Visibility.Hidden)
                    {
                        Row1[i].Visibility = Visibility.Hidden;
                        break;
                    }
                }
                played = true;
            }
        }

        private void btnRowTwo_Click(object sender, RoutedEventArgs e)
        {
            //Has 3 stones in the row
            if (gm.Subtract(2))
            {
                for (int i = Row2.Count - 1; i >= 0; i--)
                {
                    if (Row2[i].Visibility != Visibility.Hidden)
                    {
                        Row2[i].Visibility = Visibility.Hidden;
                        break;
                    }
                }
                played = true;
            }
        }

        private void btnRowThree_Click(object sender, RoutedEventArgs e)
        {
            //Has 5 stones in the row
            if (gm.Subtract(3))
            {
                for (int i = Row3.Count - 1; i >= 0; i--)
                {
                    if (Row3[i].Visibility != Visibility.Hidden)
                    {
                        Row3[i].Visibility = Visibility.Hidden;
                        break;
                    }
                }
                played = true;
            }
        }


        private void btnEndTurn_Click(object sender, RoutedEventArgs e)
        {
            //Becomes disabled when there are no more moves to make/when the game is over
            if (played == true)
            {
                if (gm.CheckWin())
                {

                }
                else
                {
                    played = false;
                }
            }
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            gm.IsPlayer1 = true;
            SetupGame();
        }

        private void btnReturnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
