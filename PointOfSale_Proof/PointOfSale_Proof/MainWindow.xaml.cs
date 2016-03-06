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

namespace PointOfSale_Proof
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

        public void loadItems()
        {
            //Would load items list from SQL database, for now will hard code items in
        }

        public void line_Input(object sender, RoutedEventArgs e)
        {
            //Will check to see if enter was pressed, then logic for determining line items
            StoreItems items = new StoreItems();
        }
    }
}
