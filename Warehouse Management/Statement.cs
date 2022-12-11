using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management
{
    class Statement
    {
        public string _itemname;
        public double _total;
        public int _itemid;
        public int _itemQuantity;
        public double _itemprice;
        public string _itemcategory;
        public int _itemendQuantity;
        public string ItemName { get => _itemname; set => _itemname = value; }
        public double Total { get => _total; set => _total = value; }
        public int ItemID { get => _itemid; set => _itemid = value; }
        public int ItemQuantity { get => _itemQuantity; set => _itemQuantity = value; }
        public double ItemPrice { get => _itemprice; set => _itemprice = value; }
        public string Itemcategory { get => _itemcategory; set => _itemcategory = value; }

        public int ItemendQuantity { get => _itemendQuantity; set => _itemendQuantity = value; }
        public Statement() 
        { 

        }


    }
}
