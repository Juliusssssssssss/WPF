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

namespace Button6._5
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

        private void CheckRed(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Red;
        }

        private void CheckYellow(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Yellow;
        }

        private void CheckGreen(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Green;
        }

        private void Hide_Checked(object sender, RoutedEventArgs e)
        {
            Green.Visibility = Visibility.Collapsed;
            Yellow.Visibility = Visibility.Collapsed;
            Red.Visibility = Visibility.Collapsed;
        }

        private void Show_Checked(object sender, RoutedEventArgs e)
        {
            Green.Visibility = Visibility.Visible;
            Yellow.Visibility = Visibility.Visible;
            Red.Visibility = Visibility.Visible;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Red.IsEnabled = true;
            Yellow.IsEnabled = true;
            Green.IsEnabled = true;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Red.IsEnabled = false;
            Yellow.IsEnabled = false;
            Green.IsEnabled = false;
        }
    }
}
