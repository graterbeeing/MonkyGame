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

namespace MonkyGame
{
    /// <summary>
    /// Interaction logic for GameTab.xaml
    /// </summary>
    public partial class GameTab : Window
    {
        private Game game;
        private Window other;
        private int countright = 0;
        private int countAnswered = 0;
        private int type;
        public GameTab(int type, Window other)
        {
            InitializeComponent();
            this.game = new Game(type);
            this.other = other;
            this.type = type;
            oporator.Text = game.CreateOporator();
            game.CreateNumbers();
            number1.Text = game.GetNum1().ToString();
            number2.Text = game.GetNum2().ToString();
        }

        private void Wait()
        {
            System.Threading.Tasks.Task.Delay(1000).Wait();
        }

        private async void Check_button(object sender, RoutedEventArgs e)
        {
            Hint_collaps();
            countAnswered++;
            Count.Content = $"Answered: {countAnswered}/10";

            if (game.CheckAnswer(answerTXT.Text))
            {
                //MessageBox.Show("yay", "yay", MessageBoxButton.OK, MessageBoxImage.Information);
                countright++;
                this.V_mark.Visibility = Visibility.Visible;
                await Task.Delay(1000);
                V_mark.Visibility = Visibility.Collapsed;
                game.CreateNumbers();
                number1.Text = game.GetNum1().ToString();
                number2.Text = game.GetNum2().ToString();
            }
            else
            {
                //MessageBox.Show("ho", "not really", MessageBoxButton.OK, MessageBoxImage.Question);
                X_mark.Visibility = Visibility.Visible;
                await Task.Delay(1000);
                X_mark.Visibility = Visibility.Collapsed;
                game.CreateNumbers();
                number1.Text = game.GetNum1().ToString();
                number2.Text = game.GetNum2().ToString();
            }
            if(countAnswered == 10)
            {
                Score_Window Points = new Score_Window(countright);
                other.Visibility = Visibility.Visible;
                Points.Visibility = Visibility.Visible;
                this.Close();
            }
        }

        private void Hint_show(object sender, RoutedEventArgs e)
        {
            hanging.Visibility = Visibility.Visible;
            HintLable.Visibility = Visibility.Visible;
            switch (type)
            {
                case 0:
                    HintLable.Text = $"what happens when you buy {game.GetNum1()} bananas and than anoher {game.GetNum2()} bananas?";
                    break;
                case 1:
                    HintLable.Text = $"What happens when you have {game.GetNum1()} bananas and someone takes from you {game.GetNum2()} bananas?";
                    break;
                case 2:
                    HintLable.Text = $"what happens when you buy {game.GetNum1()} bananas {game.GetNum2()} times?";
                    break;
                case 3:
                    HintLable.Text = $"how many boxes of {game.GetNum2()} bananas can you fill if you have {game.GetNum1()} bananas?";
                    break;
            }
        }

        private void Hint_collaps()
        {
            hanging.Visibility = Visibility.Collapsed;
            HintLable.Visibility = Visibility.Collapsed;
        }

        private void answerTXT_GotFocus(object sender, RoutedEventArgs e)
        {
            answerTXT.Text = null;
        }

        private void Close_window(object sender, RoutedEventArgs e)
        {
            this.Close();
            other.Close();
        }
    }
}
