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
        private StoreItems[] items;
        private double total;

        public Transaction()
        {
            transID = 0;
            items = new StoreItems[1];
            total = 0.0;
        }

        public Transaction(int i, StoreItems[] l, int t)
        {
            transID = i;
            items = l;
            total = t;
        }
    }
}
