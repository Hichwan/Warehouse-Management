using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Warehouse_Management
{
    class Items
    {
        private string _itemID;
        private string _name;
        private string _category;
        private string _price;
        private string _quantity;
        public List<string> Name = new List<string>();
        public List<string> ItemID = new List<string>();
        public List<string> Quantity = new List<string>();
        public List<string> Category = new List<string>();
        public List<string> Price = new List<string>();

        public void getsItemList()
        {
            StreamReader sr = new StreamReader("Items List.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                Name.Add(components[0]);
                ItemID.Add(components[1]);
                Quantity.Add(components[2]);
                Category.Add(components[3]);
                Price.Add(components[4]);
            }
            sr.Close();
        }
        public string ItemName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string ID
        {
            get
            {
                return _itemID;
            }
            set
            {
                _itemID = value;
            }
        }
        public string ItemCategory
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }
        public string ItemQuantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        public string ItemPrice
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
    }
}
