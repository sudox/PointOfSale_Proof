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
        private Transaction t;

        public MainWindow()
        {
            InitializeComponent();
        }

        public StoreItems checkItems(string input)
        {
            //Would check items in SQL database, for now will hard code items in
            StoreItems[] i = new StoreItems[] { new StoreItems("2x4-8", 2.94, "204932", "002547182942"), new StoreItems("1/2\" OSB 4x8", 12.24, "125239", "004254843612"), new StoreItems("1x6-8 Premium", 4.52, "854742", "002345859652") };
            foreach(StoreItems item in i)
            {
                if(item.getSKU() == input)
                {
                    return item;
                }

                if(item.getUPC() == input)
                {
                    return item;
                }
            }

            return null;
        }

        public void total_Click(object sender, RoutedEventArgs e)
        {
            if (t != null)
            {
                totals.Content = "$" + Convert.ToString(t.getTotal());
            }

            t = null;
        }

        public void line_Input(object sender, RoutedEventArgs e)
        {
            //Will check to see if enter was pressed, then logic for determining line item
            if(Keyboard.IsKeyDown(Key.Enter))
            {
                string input = lineInput.Text;
                lineInput.Text = "";

                StoreItems lineItem = checkItems(input);
                if(lineItem != null)
                {
                    //Add to transaction
                    if(t == null)
                    {
                        t = new Transaction();

                        lineItems_SKU.Content = "";
                        lineItems_Desc.Content = "";
                        lineItems_Price.Content = "";
                        totals.Content = "";
                    }

                    t.addItem(lineItem);

                    //Add items to screen
                    lineItems_SKU.Content += input;
                    lineItems_SKU.Content += "\n";
                    lineItems_Desc.Content += lineItem.getName();
                    lineItems_Desc.Content += "\n";
                    lineItems_Price.Content += Convert.ToString(lineItem.getPrice());
                    lineItems_Price.Content += "\n";
                }
            }
        }
    }
}
