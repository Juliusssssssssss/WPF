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

namespace Button05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int count;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CatchMe_Click(object sender, RoutedEventArgs e)
        {
            Random generator = new Random();
            double newHeight = generator.NextDouble() * (ActualHeight - CatchMe.ActualHeight);
            double newWidth = generator.NextDouble() * (ActualWidth - CatchMe.ActualWidth);
            CatchMe.Margin = new(newWidth, newHeight, 0.0, 0.0);
            count++;
            Counter.Text = $"{count}";
        }
    }
}
