using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_Proof
{
    public class StoreItems
    {
        private string name;
        private double price;
        private string sku;
        private string upc;

        public StoreItems()
        {
            name = "";
            price = 0.00;
            sku = "0";
            upc = "0";
        }

        public StoreItems(string n, double p, string s, string u)
        {
            name = n;
            price = p;
            sku = s;
            upc = u;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string n)
        {
            name = n;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double p)
        {
            price = p;
        }

        public string getSKU()
        {
            return sku;
        }

        public void setSKU(string s)
        {
            sku = s;
        }

        public string getUPC()
        {
            return upc;
        }

        public void setUPC(string u)
        {
            upc = u;
        }
    }
}
