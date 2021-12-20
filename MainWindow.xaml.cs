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
        public bool Player { get; set; } = true;
        public int Counter { get; set; }

        int scoreplayer1;
        int scoreplayer2;
        public MainWindow()
        {
            MessageBox.Show("Start the game!", "TicTacToe", MessageBoxButton.OK);

            InitializeComponent();

            NewGame();

            Player1Score.Text = "PLAYER 1 (X) score : " + scoreplayer1.ToString();
            Player2Score.Text = "PLAYER 2 (O) score : " + scoreplayer2.ToString();
        }
        public void NewGame()
        {
            Player = false;
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
            Player ^= true;

            var button = sender as Button;
            if (button.Content == "")
            {
                Counter++;
                button.Content = Player ? "X" : "O";
            }

            if (button.Content == "X")
            {
                button.Foreground = Brushes.Blue;
            } 
            else
            {
                button.Foreground = Brushes.Red;
            }


            if (Player1Win())
            {
                MessageBox.Show("Player1(X) win! Congratulations! Start new game.", "TicTacToe", MessageBoxButton.OK);
                scoreplayer1++;
                NewGame();
                Player1Score.Text = "PLAYER 1 (X) score : " + scoreplayer1.ToString();
                Player2Score.Text = "PLAYER 2 (O) score : " + scoreplayer2.ToString();
            }

            if (Player2Win())
            {
                MessageBox.Show("Player2(O) win! Congratulations! Start new game.", "TicTacToe", MessageBoxButton.OK);
                scoreplayer2++;
                NewGame();
                Player1Score.Text = "PLAYER 1 (X) score : " + scoreplayer1.ToString();
                Player2Score.Text = "PLAYER 2 (O) score : " + scoreplayer2.ToString();
            }
            if (Draw())
            {
                MessageBox.Show("Draw! Start new game.", "TicTacToe", MessageBoxButton.OK);
                NewGame();
                Player1Score.Text = "PLAYER 1 (X) score : " + scoreplayer1.ToString();
                Player2Score.Text = "PLAYER 2 (O) score : " + scoreplayer2.ToString();
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
        private void Button_Reset(object sender, RoutedEventArgs e)
        {
            scoreplayer1 = 0;
            scoreplayer2 = 0;
            Player1Score.Text = "PLAYER 1 (X) score : " + scoreplayer1.ToString();
                Player2Score.Text = "PLAYER 2 (O) score : " + scoreplayer2.ToString();
        }
    }
}
