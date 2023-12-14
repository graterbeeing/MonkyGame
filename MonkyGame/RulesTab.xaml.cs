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
    /// Interaction logic for RulesTab.xaml
    /// </summary>
    public partial class RulesTab : Window
    {
        private Window other;
        public RulesTab(Window other)
        {
            this.other = other;
            InitializeComponent();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            other.Visibility = Visibility.Visible;
            this.Close();
        }
    }
}
