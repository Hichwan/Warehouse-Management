using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Management
{

    public partial class Popout1 : Form
    {
        double totalcost;
        private WarehouseApptest BuyItem;
        int BuyID;
        public double startbalance { get; set; }
        public int AccountID { get; set; }
        public string Username { get; set; }
        public string UserPass { get; set; }
        public Popout1(WarehouseApptest buyItem)
        {
            InitializeComponent();
            this.BuyItem = buyItem;
        }

        private void ConfirmButt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDboxBuy.Text) || string.IsNullOrEmpty(QuantityBuy.Text))
            {
                MessageBox.Show("Error No Value Placed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                var statement1 = new Statement();
                statement1.ItemID = Int32.Parse(IDboxBuy.Text);
                int quantity = Int32.Parse(QuantityBuy.Text);
                for (int i = BuyItem.ItemTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = BuyItem.ItemTable.Rows[i];
                    int rowID = Convert.ToInt32(row.Cells[1].Value);
                    if (rowID == statement1.ItemID)
                    {
                        totalcost = Convert.ToDouble(row.Cells[4].Value) * quantity;
                        statement1.Total = totalcost;
                        double checkbalance = startbalance - totalcost;
                        if (checkbalance < 0)
                        {
                            MessageBox.Show("Error Not Enough Money", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            int startquant = Convert.ToInt32(row.Cells[2].Value);
                            startquant = startquant - quantity;
                            if (startquant < 0)
                            {
                                MessageBox.Show("Error Not Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                row.Cells[2].Value = startquant;
                                statement1.ItemName = row.Cells[0].Value.ToString();
                                statement1.ItemQuantity = Convert.ToInt32(QuantityBuy.Text);
                                statement1.ItemPrice = Convert.ToDouble(row.Cells[4].Value);
                                using (StreamWriter sw = new StreamWriter("Action log.txt", append: true))
                                {
                                    StringBuilder sb = new StringBuilder();
                                    StringBuilder sb2 = new StringBuilder();
                                    sb.AppendLine("User #:" + AccountID + " For Item ID: " + row.Cells[1].Value.ToString() + ", " + QuantityBuy.Text + " Have been bought for a new total of: " + startquant + " Total selling price: " + totalcost);
                                    sb2.AppendLine("User #:" + AccountID + " Has A New Balance Of: " + checkbalance + " From: " + startbalance);
                                    sw.Write(sb.ToString());
                                    sw.WriteLine(sb2.ToString());
                                }
                                /*                               using (StreamWriter sw2 = new StreamWriter("December.txt", append: true))
                                                               {
                                                                   StringBuilder sb4 = new StringBuilder();
                                                                   sb4.AppendLine(row.Cells[0].Value.ToString() + "," + row.Cells[1].Value.ToString() + "," + row.Cells[4].Value.ToString() + "," + QuantityBuy.Text + "," + totalcost);
                                                                   sw2.Write(sb4.ToString());
                                                               }
                                */
                                statement1.WriteStatementLog();
                                BuyItem.Balance.Text = Convert.ToString(checkbalance);
                                string[] arrLine = File.ReadAllLines("AccountList.txt");
                                StringBuilder sb3 = new StringBuilder();
                                sb3.Append(Username + " " + AccountID + " " + UserPass + " " + checkbalance);
                                arrLine[AccountID - 1] = sb3.ToString();
                                File.WriteAllLines("AccountList.txt", arrLine);

                                string[] arrLine2 = File.ReadAllLines("Items List.txt");
                                StringBuilder sb4 = new StringBuilder();
                                sb4.Append(statement1.ItemName + "," + statement1.ItemID + "," + row.Cells[2].Value + "," + row.Cells[3].Value.ToString() + "," + statement1.ItemPrice);
                                arrLine2[statement1.ItemID - 1] = sb4.ToString();
                                File.WriteAllLines("Items List.txt", arrLine2);
                                this.Close();
                            }
                        }
                        
                    }
                }
            }
        }

        private void CancelButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuantityBuy_TextChanged(object sender, EventArgs e)
        {
            BuyID = Int32.Parse(IDboxBuy.Text);
            int quantity = Int32.Parse(QuantityBuy.Text);
            for (int i = BuyItem.ItemTable.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = BuyItem.ItemTable.Rows[i];
                int rowID = Convert.ToInt32(row.Cells[1].Value);
                if (rowID == BuyID)
                {
                    totalcost = Convert.ToDouble(row.Cells[4].Value) * quantity;
                    EstCost.Text = Convert.ToString(totalcost);
                }
            }
        }

        private void IDboxBuy_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isNumber = Char.IsNumber(e.KeyChar);
            if (!isNumber)
            {
                e.Handled = true;
                MessageBox.Show("Only numeric input is accepted");
            }
        }

        private void QuantityBuy_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isNumber = Char.IsNumber(e.KeyChar);
            if (!isNumber)
            {
                e.Handled = true;
                MessageBox.Show("Only numeric input is accepted");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

    }
}
