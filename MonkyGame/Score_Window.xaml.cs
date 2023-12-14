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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MonkyGame
{
    /// <summary>
    /// Interaction logic for Score_Window.xaml
    /// </summary>
    public partial class Score_Window : Window
    {
        private int score;
        public Score_Window(int Points)
        {
            this.score = Points;
            InitializeComponent();
            test.Content = $"You got {(Points).ToString()}0 Points";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
