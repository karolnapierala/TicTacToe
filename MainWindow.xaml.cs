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
            MessageBox.Show("Start the game!", "TicTacToe", MessageBoxButton.OK);

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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Player1 ^= true;
            Counter++;

            var button = sender as Button;
            button.Content = Player1 ? "X" : "O";

            if (Player1Win())
            {
                MessageBox.Show("Player1(X) win! Congratulations! Start new game.", "TicTacToe", MessageBoxButton.OK);
                NewGame();
            }

            if (Player2Win())
            {
                MessageBox.Show("Player2(O) win! Congratulations! Start new game.", "TicTacToe", MessageBoxButton.OK);
                NewGame();
            }
            if (Draw())
            {
                MessageBox.Show("Draw! Congratulations! Start new game.", "TicTacToe", MessageBoxButton.OK);
                NewGame();
            }
        }

        private bool Player1Win()
        {
            if(Button_0_0.Content.ToString() == "X" && Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_1_0.Content && Button_1_0.Content == Button_2_0.Content)
            {
                Button_0_0.Background = Brushes.LightGreen;
                Button_1_0.Background = Brushes.LightGreen;
                Button_2_0.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_0_1.Content.ToString() == "X" && Button_0_1.Content.ToString() != string.Empty && Button_0_1.Content == Button_1_1.Content && Button_1_1.Content == Button_2_1.Content)
            {
                Button_0_1.Background = Brushes.LightGreen;
                Button_1_1.Background = Brushes.LightGreen;
                Button_2_1.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_0_2.Content.ToString() == "X" && Button_0_2.Content.ToString() != string.Empty && Button_0_2.Content == Button_1_2.Content && Button_1_2.Content == Button_2_2.Content)
            {
                Button_0_2.Background = Brushes.LightGreen;
                Button_1_2.Background = Brushes.LightGreen;
                Button_2_2.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_0_0.Content.ToString() == "X" && Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_0_1.Content && Button_0_1.Content == Button_0_2.Content)
            {
                Button_0_0.Background = Brushes.LightGreen;
                Button_0_1.Background = Brushes.LightGreen;
                Button_0_2.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_1_0.Content.ToString() == "X" && Button_1_0.Content.ToString() != string.Empty && Button_1_0.Content == Button_1_1.Content && Button_1_1.Content == Button_1_2.Content)
            {
                Button_1_0.Background = Brushes.LightGreen;
                Button_1_1.Background = Brushes.LightGreen;
                Button_1_2.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_2_0.Content.ToString() == "X" && Button_2_0.Content.ToString() != string.Empty && Button_2_0.Content == Button_2_1.Content && Button_2_1.Content == Button_2_2.Content)
            {
                Button_2_0.Background = Brushes.LightGreen;
                Button_2_1.Background = Brushes.LightGreen;
                Button_2_2.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_0_0.Content.ToString() == "X" && Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_1_1.Content && Button_1_1.Content == Button_2_2.Content)
            {
                Button_0_0.Background = Brushes.LightGreen;
                Button_1_1.Background = Brushes.LightGreen;
                Button_2_2.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_2_0.Content.ToString() == "X" && Button_2_0.Content.ToString() != string.Empty && Button_2_0.Content == Button_1_1.Content && Button_1_1.Content == Button_0_2.Content)
            {
                Button_2_0.Background = Brushes.LightGreen;
                Button_1_1.Background = Brushes.LightGreen;
                Button_0_2.Background = Brushes.LightGreen;
                return true;
            }
            return false;
        }
        private bool Player2Win()
        {
            if (Button_0_0.Content.ToString() == "O" && Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_1_0.Content && Button_1_0.Content == Button_2_0.Content)
            {
                Button_0_0.Background = Brushes.LightGreen;
                Button_1_0.Background = Brushes.LightGreen;
                Button_2_0.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_0_1.Content.ToString() == "O" && Button_0_1.Content.ToString() != string.Empty && Button_0_1.Content == Button_1_1.Content && Button_1_1.Content == Button_2_1.Content)
            {
                Button_0_1.Background = Brushes.LightGreen;
                Button_1_1.Background = Brushes.LightGreen;
                Button_2_1.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_0_2.Content.ToString() == "O" && Button_0_2.Content.ToString() != string.Empty && Button_0_2.Content == Button_1_2.Content && Button_1_2.Content == Button_2_2.Content)
            {
                Button_0_2.Background = Brushes.LightGreen;
                Button_1_2.Background = Brushes.LightGreen;
                Button_2_2.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_0_0.Content.ToString() == "O" && Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_0_1.Content && Button_0_1.Content == Button_0_2.Content)
            {
                Button_0_0.Background = Brushes.LightGreen;
                Button_0_1.Background = Brushes.LightGreen;
                Button_0_2.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_1_0.Content.ToString() == "O" && Button_1_0.Content.ToString() != string.Empty && Button_1_0.Content == Button_1_1.Content && Button_1_1.Content == Button_1_2.Content)
            {
                Button_1_0.Background = Brushes.LightGreen;
                Button_1_1.Background = Brushes.LightGreen;
                Button_1_2.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_2_0.Content.ToString() == "O" && Button_2_0.Content.ToString() != string.Empty && Button_2_0.Content == Button_2_1.Content && Button_2_1.Content == Button_2_2.Content)
            {
                Button_2_0.Background = Brushes.LightGreen;
                Button_2_1.Background = Brushes.LightGreen;
                Button_2_2.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_0_0.Content.ToString() == "O" && Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_1_1.Content && Button_1_1.Content == Button_2_2.Content)
            {
                Button_0_0.Background = Brushes.LightGreen;
                Button_1_1.Background = Brushes.LightGreen;
                Button_2_2.Background = Brushes.LightGreen;
                return true;
            }
            if (Button_2_0.Content.ToString() == "O" && Button_2_0.Content.ToString() != string.Empty && Button_2_0.Content == Button_1_1.Content && Button_1_1.Content == Button_0_2.Content)
            {
                Button_2_0.Background = Brushes.LightGreen;
                Button_1_1.Background = Brushes.LightGreen;
                Button_0_2.Background = Brushes.LightGreen;
                return true;
            }
            return false;
        }
        private bool Draw()
        {
            if (Counter == 9)
            {
                NewGame();
                return true;
            }
            return false;
        }
    }
}
