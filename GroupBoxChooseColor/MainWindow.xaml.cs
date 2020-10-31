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

namespace GroupBoxChooseColor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RBBlue_Checked(object sender, RoutedEventArgs e)
        {
            rColor.Fill = Brushes.Blue;
        }

        private void RbYellow_Checked(object sender, RoutedEventArgs e)
        {
            rColor.Fill = Brushes.Yellow;
        }

        private void RBOrange_Checked(object sender, RoutedEventArgs e)
        {
            rColor.Fill = Brushes.Orange;
        }
    }
}
