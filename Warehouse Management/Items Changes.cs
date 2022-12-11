using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management
{
    class Changes : Items
    {
        public void ModifyChange(string name, int ID, int quantity, string category, double price)
        {
            string[] arrLine2 = File.ReadAllLines("Items List.txt");
            StringBuilder sb4 = new StringBuilder();
            sb4.Append(name + ", " + ID + ", " + quantity + ", " + category + ", " + price);
            arrLine2[ID - 1] = sb4.ToString();
            File.WriteAllLines("Items List.txt", arrLine2);
        }
        public void ModifyChange(int UserID, string Modifier, int ItemID, string change, string endvalue)
        {
            using (StreamWriter sw = new StreamWriter("Action log.txt", append: true))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("User #:" + UserID + " Modified" + " " + Modifier + " " + "For Item ID" + " " + ItemID + " From: " + change + " To: " + endvalue);
                sw.WriteLine(sb.ToString());
            }
        }

        public void AddChange(int AccountID, string NameItemAdd, int IDcount, string QuantityNew, string CatNew, string CostNew)
        {
            using (StreamWriter sw = new StreamWriter("Action log.txt", append: true))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("User #:" + AccountID + " Added: " + NameItemAdd + " " + IDcount + " " + QuantityNew + " " + CatNew + " " + CostNew);
                sw.WriteLine(sb.ToString());
            }
        }
        public void AddChange(string NameItemAdd, int IDcount, string QuantityNew, string CatNew, string CostNew)
        {
            using (StreamWriter sw2 = new StreamWriter("Items List.txt", append: true))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(NameItemAdd + ", " + IDcount + ", " + QuantityNew + ", " + CatNew + ", " + CostNew);
                sw2.Write(sb.ToString());
            }
        }

        public void DeleteChange(int AccountID, string Name, int ID, int Quantity, string Category, double Price)
        {
            using (StreamWriter sw = new StreamWriter("Action log.txt", append: true))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("User #:" + AccountID + " Deleted:" + " " + Name + " " + ID + " " + Quantity + " " + Category + " " + Price);
                sw.WriteLine(sb.ToString());
            }
        }
        public void DeleteChange(int DeleteId)
        {
            string[] arrLine2 = File.ReadAllLines("Items List.txt");
            arrLine2[DeleteId - 1] = null;
            File.WriteAllLines("Items List.txt", arrLine2);
            var lines = File.ReadAllLines("Items List.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
            File.WriteAllLines("Items LIst.txt", lines);
        }

        public void BalanceChange(int AccountID, double Amount)
        {
            using (StreamWriter sw = new StreamWriter("Action log.txt", append: true))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("User #:" + AccountID + " Added: " + Amount + " to account.");
                sw.WriteLine(sb.ToString());
            }
        }

        public void BuyChangeLog(int AccountID, int ItemID, int QuantityBuy, int Startquant, double Totalcost, double Checkbalance, double Startbalance)
        {
            using (StreamWriter sw = new StreamWriter("Action log.txt", append: true))
            {
                StringBuilder sb = new StringBuilder();
                StringBuilder sb2 = new StringBuilder();
                sb.AppendLine("User #:" + AccountID + " For Item ID: " + ItemID + ", " + QuantityBuy + " Have been bought for a new total of: " + Startquant + " Total selling price: " + Totalcost);
                sb2.AppendLine("User #:" + AccountID + " Has A New Balance Of: " + Checkbalance + " From: " + Startbalance);
                sw.Write(sb.ToString());
                sw.WriteLine(sb2.ToString());
            }
        }
    }
}
