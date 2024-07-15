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
    /// Interaction logic for MenuScreen.xaml
    /// </summary>
    public partial class MenuScreen : Window
    {
        
        public MenuScreen()
        {
            InitializeComponent();
        }


        private void btnGame_Click(object sender, RoutedEventArgs e)
        {
            //Set player names
            GameManager gm = new GameManager(txtPlayer1.Text, txtPlayer2.Text);

            GameScreenEasy gameScreenEasy = new GameScreenEasy(gm);
            GameScreenMedium gameScreenMedium = new GameScreenMedium(gm);
            GameScreenHard gameScreenHard = new GameScreenHard(gm);
            
            //This will open a certain game screen based on the selected difficulty
            if (rbEasy.IsChecked == true)
            {
                gameScreenEasy.Show();
                this.Close();
                SetGameDifficulty("Easy", gm);
            }
            else if (rbMedium.IsChecked == true)
            {
                gameScreenMedium.Show();
                this.Close();
                SetGameDifficulty("Medium", gm);
            }
            else if (rbHard.IsChecked == true)
            {
                gameScreenHard.Show();
                this.Close();
                SetGameDifficulty("Hard", gm);
            }
            
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null)
            {
                string selectedDifficulty = radioButton.Content.ToString();
                // Now you can use selectedDifficulty to set the game's difficulty level
                //SetGameDifficulty(selectedDifficulty);
            }
        }

        private void SetGameDifficulty(string difficulty, GameManager gm)
        {
            // Implement the logic to set the game's difficulty based on the selected option
            switch (difficulty)
            {
                case "Easy":
                    // Set easy difficulty {Has 3 rows/9 stones}
                    gm.DiffType = DifficultyType.EASY;
                    break;
                case "Medium":
					// Set medium difficulty {Has 4 rows/16 stones}
					gm.DiffType = DifficultyType.MEDIUM;
					break;
                case "Hard":
					// Set hard difficulty {Has 5 rows/36 stones}
					gm.DiffType = DifficultyType.HARD;
					break;
            }
        }
    }
}
