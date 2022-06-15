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

namespace Button6._4
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

        private void BoxOne_Checked(object sender, RoutedEventArgs e)
        {
            BoxOne.Content = "Checked";
        }

        private void BoxTwo_Checked(object sender, RoutedEventArgs e)
        {
            BoxTwo.Content = "Checked";
        }

        private void BoxThree_Checked(object sender, RoutedEventArgs e)
        {
            BoxThree.Content = "Checked";
        }

        private void BoxThree_Unchecked(object sender, RoutedEventArgs e)
        {
            BoxThree.Content = "Mystery CheckBox 3";
        }

        private void BoxTwo_Uncheked(object sender, RoutedEventArgs e)
        {
            BoxTwo.Content = "Mystery CheckBox 2";
        }

        private void BoxOne_Uncheked(object sender, RoutedEventArgs e)
        {
            BoxOne.Content = "Mystery CheckBox 1";
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Collection_Indeterminate(object sender, RoutedEventArgs e)
        {
            BoxOne.IsChecked = null;
            BoxTwo.IsChecked = null;
            BoxThree.IsChecked = null;
            BoxOne.Content = "Maybe";
            BoxTwo.Content = "Maybe";
            BoxThree.Content = "Maybe";
        }
    }
}
