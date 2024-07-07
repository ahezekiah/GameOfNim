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
            GameScreenEasy gameScreenEasy = new GameScreenEasy();
            GameScreenMedium gameScreenMedium = new GameScreenMedium();
            GameScreenHard gameScreenHard = new GameScreenHard();

            //This will open a certain game screen based on the selected difficulty
            
            if (rbEasy.IsChecked == true)
            {
                SetGameDifficulty("Easy");
                gameScreenEasy.Show();
                this.Hide();
            }
            else if (rbMedium.IsChecked == true)
            {
                SetGameDifficulty("Medium");
                gameScreenMedium.Show();
                this.Hide();
            }
            else if (rbHard.IsChecked == true)
            {
                SetGameDifficulty("Hard");
                gameScreenHard.Show();
                this.Hide();
            }
            
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null)
            {
                string selectedDifficulty = radioButton.Content.ToString();
                // Now you can use selectedDifficulty to set the game's difficulty level
                SetGameDifficulty(selectedDifficulty);
            }
        }

        private void SetGameDifficulty(string difficulty)
        {
            // Implement the logic to set the game's difficulty based on the selected option
            switch (difficulty)
            {
                case "Easy":
                    // Set easy difficulty {Has 4 rows/10 stones}
                    break;
                case "Medium":
                    // Set medium difficulty {Has 5 rows/15 stones}
                    break;
                case "Hard":
                    // Set hard difficulty {Has 6 rows/21 stones}
                    break;
            }
        }
    }
}
