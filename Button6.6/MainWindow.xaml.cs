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

namespace Button6._6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Product> Name = new()
        {
            new() { Name = "Faxe Kondi", Category="Drinks", ID = "ID01", ExpirationDate = new(2010, 10, 1), RegisteringDate = new(2010, 10, 1), UnityCost = 5 },
            new() { Name = "Coca Cola", Category="Drinks", ID = "ID02", ExpirationDate = new(2011, 10, 1), RegisteringDate = new(2011, 10, 1), UnityCost = 100 },
            new() { Name = "Fanta", Category="Drinks", ID= "ID03", ExpirationDate = new(2012, 10, 1), RegisteringDate = new(2012, 10, 1), UnityCost = 250},
            new() { Name = "Cobblestone", Category="Building Materials", ID = "ID04", ExpirationDate = new(2013, 10, 1), RegisteringDate = new(2013, 10, 1), UnityCost = 25000 },
            new() { Name = "Soulsand", Category="Building Materials", ID="ID05", ExpirationDate = new(2014, 10, 1), RegisteringDate = new(2014, 10, 1), UnityCost = 50},
            new() { Name = "Dirt", Category="Building Materials", ID="ID06", ExpirationDate = new(2015, 10, 1), RegisteringDate = new(2015, 10, 1), UnityCost = 500},
            new() { Name = "Grass", Category="Building Materials", ID="ID07", ExpirationDate = new(2016, 10, 1), RegisteringDate = new(2016, 10, 1), UnityCost = 300},
            new() { Name = "Sunglasses", Category = "Accessories", ID="ID08", ExpirationDate = new(2017, 10, 1), RegisteringDate = new(2017, 10, 1), UnityCost = 245},
            new() { Name = "Boots", Category = "Accessories", ID="ID09", ExpirationDate = new(2018, 10, 1), RegisteringDate = new(2018, 10, 1), UnityCost = 7000},
            new() { Name = "Moonglasses", Category = "Accessories", ID="ID10", ExpirationDate = new(2019, 10, 1), RegisteringDate = new(2019, 10, 1), UnityCost = 60}
        };
        public MainWindow()
        {
            InitializeComponent();
            ListBox.ItemsSource = Name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = TextBoxName.Text;
            string category = TextBoxCategory.Text;
            DateTime registering = TextBoxRD.SelectedDate.Value;
            int unitcost = int.Parse(TextBoxUP.Text);

            Name i = new() { Name = name, Category = category, ID="ID11", ExpirationDate = new(2019, 10, 1), RegisteringDate = registering, UnityCost = unitcost };
            Name.Add(i);
        }
    }
}


