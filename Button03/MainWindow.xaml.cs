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

namespace Button03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int count;
        private int totalClicks;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tælOp_Click(object sender, RoutedEventArgs e)
        {
            count++;
            textBlock.Text = $"{count}";
            totalClicks++;
            totalclicks.Text = $"{totalClicks}";
        }

        private void tælNed_Click(object sender, RoutedEventArgs e)
        {
            count--;
            textBlock.Text = $"{count}";
            totalClicks++;
            totalclicks.Text = $"{totalClicks}";
        }

    }
}
