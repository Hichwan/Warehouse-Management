using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management
{
    class Statement
    {
        private string _itemname;
        private double _total;
        private int _itemid;
        private int _itemQuantity;
        private double _itemprice;
        public string ItemName { get => _itemname; set => _itemname = value; }
        public double Total { get => _total; set => _total = value; }
        public int ItemID { get => _itemid; set => _itemid = value; }
        public int ItemQuantity { get => _itemQuantity; set => _itemQuantity = value; }
        public double ItemPrice { get => _itemprice; set => _itemprice = value; }

        public Statement() 
        { 

        }
        public void WriteStatementLog()
        {
            using (StreamWriter sw2 = new StreamWriter("December.txt", append: true))
            {
                StringBuilder sb4 = new StringBuilder();
                sb4.AppendLine(_itemname + "," + _itemid + "," + _itemprice + "," + _itemQuantity + "," + _total);
                sw2.Write(sb4.ToString());
            }
        }
    }
}
