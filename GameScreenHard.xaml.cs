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
    /// Interaction logic for GameScreenHard.xaml
    /// </summary>
    public partial class GameScreenHard : Window
    {
        GameManager gm = new GameManager();
		WinScreen winScreen = new WinScreen();

		private bool played = false;

		private List<Image> Row1 = new List<Image>();
		private List<Image> Row2 = new List<Image>();
		private List<Image> Row3 = new List<Image>();
		private List<Image> Row4 = new List<Image>();
        private List<Image> Row5 = new List<Image>();

		public GameScreenHard(GameManager gm)
        {
            InitializeComponent();
            this.gm = gm;

            Row1.Add(Stone1);
            Row1.Add(Stone2);
            Row1.Add(Stone3);

            Row2.Add(Stone4);
            Row2.Add(Stone5);
            Row2.Add(Stone6);
            Row2.Add(Stone7);
            Row2.Add(Stone8);

            Row3.Add(Stone9);
            Row3.Add(Stone10);
            Row3.Add(Stone11);
            Row3.Add(Stone12);
            Row3.Add(Stone13);
            Row3.Add(Stone14);
            Row3.Add(Stone15);

            Row4.Add(Stone16);
            Row4.Add(Stone17);
            Row4.Add(Stone18);
            Row4.Add(Stone19);
            Row4.Add(Stone20);
            Row4.Add(Stone21);
            Row4.Add(Stone22);
            Row4.Add(Stone23);
            Row4.Add(Stone24);

            Row5.Add(Stone25);
            Row5.Add(Stone26);
            Row5.Add(Stone27);
            Row5.Add(Stone28);
            Row5.Add(Stone29);
            Row5.Add(Stone30);
            Row5.Add(Stone31);
            Row5.Add(Stone32);
            Row5.Add(Stone33);
            Row5.Add(Stone34);
            Row5.Add(Stone35);

			gameData.Text = "Welcome to the Game! It's " + gm.PlayerOne.Name + "'s turn!";

			SetupGame();
        }

        private void SetupGame()
        {
			tbLabel1.Text = gm.PlayerOne.Name;
			tbLabel2.Text = gm.PlayerTwo.Name;

			gm.Hard();
			played = false;

			for (int i = Row1.Count - 1; i >= 0; i--)
			{
				Row1[i].Visibility = Visibility.Visible;
			}
			for (int i = Row2.Count - 1; i >= 0; i--)
			{
				Row2[i].Visibility = Visibility.Visible;
			}
			for (int i = Row3.Count - 1; i >= 0; i--)
			{
				Row3[i].Visibility = Visibility.Visible;
			}
			for (int i = Row4.Count - 1; i >= 0; i--)
			{
				Row4[i].Visibility = Visibility.Visible;
			}
            for (int i = Row5.Count - 1; i >= 0; i--)
            {
                Row5[i].Visibility = Visibility.Visible;
            }
		}

        private void btnRowOne_Click(object sender, RoutedEventArgs e)
        {
			//Has 3 stones in the row
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
			else
			{
				gameData.Text = "Can't take a stone from that row.";
			}
		}

        private void btnRowTwo_Click(object sender, RoutedEventArgs e)
        {
			//Has 5 stones in the row
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
			else
			{
				gameData.Text = "Can't take a stone from that row.";
			}
		}

        private void btnRowThree_Click(object sender, RoutedEventArgs e)
        {
			//Has 7 stones in the row
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
			else
			{
				gameData.Text = "Can't take a stone from that row.";
			}
		}

        private void btnRowFour_Click(object sender, RoutedEventArgs e)
        {
			//Has 9 stones in the row
			if (gm.Subtract(4))
			{
				for (int i = Row4.Count - 1; i >= 0; i--)
				{
					if (Row4[i].Visibility != Visibility.Hidden)
					{
						Row4[i].Visibility = Visibility.Hidden;
						break;
					}
				}
				played = true;
			}
			else
			{
				gameData.Text = "Can't take a stone from that row.";
			}
		}

        private void btnRowFive_Click(object sender, RoutedEventArgs e)
        {
			//Has 11 stones in the row
			if (gm.Subtract(5))
			{
				for (int i = Row5.Count - 1; i >= 0; i--)
				{
					if (Row5[i].Visibility != Visibility.Hidden)
					{
						Row5[i].Visibility = Visibility.Hidden;
						break;
					}
				}
				played = true;
			}
			else
			{
				gameData.Text = "Can't take a stone from that row.";
			}
		}

        

        private void btnEndTurn_Click(object sender, RoutedEventArgs e)
        {
			//Becomes disabled when there are no more moves to make/when the game is over
			if (played == true)
			{
				if (gm.CheckWin())
				{
					winScreen.Setup(gm.PlayerOne.Name, gm.PlayerTwo.Name, "Easy", !gm.IsPlayer1);
					winScreen.Show();
					this.Close();
				}
				else
				{
					if (gm.IsPlayer1)
					{
						gameData.Text = gm.PlayerOne.Name + "'s turn.";
					}
					else
					{
						gameData.Text = gm.PlayerTwo.Name + "'s turn.";
					}
					played = false;
				}
			}
			else
			{
				gameData.Text = "Can't end turn, you must take a stone.";
			}
		}

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
			//Starts a new game OR resets the current game
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
