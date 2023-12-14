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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private int type = 0;

        private void Rules_Open(object sender, RoutedEventArgs e)
        {
            RulesTab rulesTab = new RulesTab(this.HomeWindow);
            HomeWindow.Visibility = Visibility.Collapsed;
            rulesTab.Visibility = Visibility.Visible;
        }

        private void Game_Open(object sender, RoutedEventArgs e)
        {
            GameTab gameTab = new GameTab(type, this.HomeWindow);
            HomeWindow.Visibility = Visibility.Collapsed;
            gameTab.Visibility = Visibility.Visible;
        }

        private void Add_Check(object sender, RoutedEventArgs e)
        {
            type = 0;
        }

        private void Sub_Check(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry, not implemented", "Work in progress", MessageBoxButton.OK, MessageBoxImage.Hand, MessageBoxResult.OK);
            type = 0;
        }

        private void Mult_Check(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry, not implemented", "Work in progress", MessageBoxButton.OK, MessageBoxImage.Hand, MessageBoxResult.OK);
            type = 0;
        }

        private void Dev_Check(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry, not implemented", "Work in progress", MessageBoxButton.OK, MessageBoxImage.Hand, MessageBoxResult.OK);
            type = 0;
        }
    }
}
