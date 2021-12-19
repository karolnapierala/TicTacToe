using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace tictactoe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool Player1 { get; set; } = true;
        public int Counter { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            NewGame();
        }

        public void NewGame()
        {
            Player1 = false;
            Counter = 0;
            Button_0_0.Content = string.Empty;
            Button_1_0.Content = string.Empty;
            Button_2_0.Content = string.Empty;
            Button_0_1.Content = string.Empty;
            Button_1_1.Content = string.Empty;
            Button_2_1.Content = string.Empty;
            Button_0_2.Content = string.Empty;
            Button_1_2.Content = string.Empty;
            Button_2_2.Content = string.Empty;

            Button_0_0.Background = Brushes.LightCyan;
            Button_1_0.Background = Brushes.LightCyan;
            Button_2_0.Background = Brushes.LightCyan;
            Button_0_1.Background = Brushes.LightCyan;
            Button_1_1.Background = Brushes.LightCyan;
            Button_2_1.Background = Brushes.LightCyan;
            Button_0_2.Background = Brushes.LightCyan;
            Button_1_2.Background = Brushes.LightCyan;
            Button_2_2.Background = Brushes.LightCyan;
            MessageBox.Show("START THE GAME", "TicTacToe", MessageBoxButton.OK);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Player1 ^= true;
            Counter++;

            if (Counter > 9)
            {
                NewGame();
                return;
            }

            var button = sender as Button;
            button.Content = Player1 ? "X" : "O";

            if (PlayerWin())
            {
                Counter = 9;
            }
        }

        private bool PlayerWin()
        {
            if(Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_1_0.Content && Button_1_0.Content == Button_2_0.Content)
            {
                Button_0_0.Background = Brushes.LightGreen;
                Button_1_0.Background = Brushes.LightGreen;
                Button_2_0.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_0_1.Content.ToString() != string.Empty && Button_0_1.Content == Button_1_1.Content && Button_1_1.Content == Button_2_1.Content)
            {
                Button_0_1.Background = Brushes.LightGreen;
                Button_1_1.Background = Brushes.LightGreen;
                Button_2_1.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_0_2.Content.ToString() != string.Empty && Button_0_2.Content == Button_1_2.Content && Button_1_2.Content == Button_2_2.Content)
            {
                Button_0_2.Background = Brushes.LightGreen;
                Button_1_2.Background = Brushes.LightGreen;
                Button_2_2.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_0_1.Content && Button_0_1.Content == Button_0_2.Content)
            {
                Button_0_0.Background = Brushes.LightGreen;
                Button_0_1.Background = Brushes.LightGreen;
                Button_0_2.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_1_0.Content.ToString() != string.Empty && Button_1_0.Content == Button_1_1.Content && Button_1_1.Content == Button_1_2.Content)
            {
                Button_1_0.Background = Brushes.LightGreen;
                Button_1_1.Background = Brushes.LightGreen;
                Button_1_2.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_2_0.Content.ToString() != string.Empty && Button_2_0.Content == Button_2_1.Content && Button_2_1.Content == Button_2_2.Content)
            {
                Button_2_0.Background = Brushes.LightGreen;
                Button_2_1.Background = Brushes.LightGreen;
                Button_2_2.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_1_1.Content && Button_1_1.Content == Button_2_2.Content)
            {
                Button_0_0.Background = Brushes.LightGreen;
                Button_1_1.Background = Brushes.LightGreen;
                Button_2_2.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_2_0.Content.ToString() != string.Empty && Button_2_0.Content == Button_1_1.Content && Button_1_1.Content == Button_0_2.Content)
            {
                Button_2_0.Background = Brushes.LightGreen;
                Button_1_1.Background = Brushes.LightGreen;
                Button_0_2.Background = Brushes.LightGreen;
                return true;
            }

            return false;
        }
    }
}
