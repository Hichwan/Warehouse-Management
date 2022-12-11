using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Warehouse_Management
{
    class Transaction : Statement
    {
        public void WriteStatementLog()
        {
            using (StreamWriter sw2 = new StreamWriter("December.txt", append: true))
            {
                StringBuilder sb4 = new StringBuilder();
                sb4.AppendLine(_itemname + "," + _itemid + "," + _itemprice + "," + _itemQuantity + "," + _total);
                sw2.Write(sb4.ToString());
            }
        }

        public void ModifyItemList()
        {
            string[] arrLine2 = File.ReadAllLines("Items List.txt");
            StringBuilder sb4 = new StringBuilder();
            sb4.Append(_itemname + "," + _itemid + "," + _itemendQuantity + "," + _itemcategory + "," + _itemprice);
            arrLine2[_itemid - 1] = sb4.ToString();
            File.WriteAllLines("Items List.txt", arrLine2);
        }

        public void ModifyAccount(string User, int ID, string pass, double balance)
        {
            string[] arrLine = File.ReadAllLines("AccountList.txt");
            StringBuilder sb3 = new StringBuilder();
            sb3.Append(User + " " + ID + " " + pass + " " + balance);
            arrLine[ID - 1] = sb3.ToString();
            File.WriteAllLines("AccountList.txt", arrLine);
        }
    }
}
