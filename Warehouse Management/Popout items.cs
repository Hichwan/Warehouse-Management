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
        public Popout1(WarehouseApptest buyItem)
        {
            InitializeComponent();
            this.BuyItem = buyItem;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmButt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDboxBuy.Text) || string.IsNullOrEmpty(QuantityBuy.Text))
            {
                MessageBox.Show("Error No Value Placed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
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
                        int startquant = Convert.ToInt32(row.Cells[2].Value);
                        startquant = startquant - quantity;
                        row.Cells[2].Value = startquant;
                        using (StreamWriter sw = new StreamWriter("Action log.txt", append: true))
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("For Item ID: " + row.Cells[1].Value.ToString() + ", " + QuantityBuy.Text + " Have been bought for a new total of: " + startquant + " Total selling price: " + totalcost);
                            sw.WriteLine(sb.ToString());
                        }
                        using (StreamWriter sw = new StreamWriter("December.txt", append: true))
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine(row.Cells[0].Value.ToString() + "," + row.Cells[1].Value.ToString() + "," + row.Cells[4].Value.ToString() + "," + QuantityBuy.Text + "," + totalcost);
                            sw.Write(sb.ToString());
                        }
                    }
                }
            }
        }

        private void CancelButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            }
        

        private void label1_Click_1(object sender, EventArgs e)
        {

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
    }
}
