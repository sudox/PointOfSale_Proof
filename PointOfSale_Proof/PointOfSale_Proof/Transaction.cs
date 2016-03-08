using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_Proof
{
    class Transaction
    {
        private int transID;
        private List<StoreItems> items;
        private double total;

        public Transaction()
        {
            transID = 0;
            items = new List<StoreItems>();
            total = 0.0;
        }

        public Transaction(int i, List<StoreItems> l, int t)
        {
            transID = i;
            items = l;
            total = t;
        }

        public int getTransactionID()
        {
            return transID;
        }

        public void setTransactionID(int i)
        {
            transID = i;
        }

        public List<StoreItems> getItems()
        {
            return items;
        }

        public void addItemList(List<StoreItems> l)
        {
            items = l;
            foreach(StoreItems i in l)
            {
                total += i.getPrice();
            }
        }

        public StoreItems getItem(int location)
        {
            if (items.Count > location)
            {
                return items.ElementAt(location);
            }

            else
            {
                return null;
            }
        }

        public void addItem(StoreItems i)
        {
            items.Add(i);
            total += i.getPrice();
        }

        public double getTotal()
        {
            return total;
        }
    }
}
