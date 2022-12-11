using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Management
{
    public partial class ModifyItems : Form
    {
        private WarehouseApptest ModItem;
        int modifier;
        public int AccountID { get; set; }

        public ModifyItems(WarehouseApptest modify)
        {
            InitializeComponent();
            this.ModItem = modify;
        }

        private void CancelButtCanc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Mod = ModList.Text;
            switch (Mod)
            {
                case "Name":
                    modifier = 1;
                    break;
                case "Quantity":
                    modifier = 2;
                    break;
                case "Category":
                    modifier = 3;
                    break;
                case "Price":
                    modifier = 4;
                    break;
            }
        }
        private void ConfirmButtBuy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDboxMod.Text) || string.IsNullOrEmpty(ChangeBox.Text))
            {
                MessageBox.Show("Error No Value Placed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                int ChangeID = Int32.Parse(IDboxMod.Text);
                for (int i = ModItem.ItemTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = ModItem.ItemTable.Rows[i];
                    int rowID = Convert.ToInt32(row.Cells[1].Value);
                    if (rowID == ChangeID)
                    {
                        var items1 = new Changes();
                        items1.ModifyChange(Convert.ToInt32(AccountID), Convert.ToString(ModList.Text), Convert.ToInt32(row.Cells[1].Value), row.Cells[modifier].Value.ToString(), Convert.ToString(ChangeBox.Text));
                        row.Cells[modifier].Value = ChangeBox.Text;                        
                        items1.ModifyChange(row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[1].Value), Convert.ToInt32(row.Cells[2].Value), row.Cells[3].Value.ToString(), Convert.ToDouble(row.Cells[4].Value));
                        this.Close();
                    }
                }

                IDboxMod.Clear();
                ChangeBox.Clear();
            }
        }


        private void IDboxMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isNumber = Char.IsNumber(e.KeyChar);
            if (!isNumber)
            {
                e.Handled = true;
                MessageBox.Show("Only numeric input is accepted");
            }
        }

        private void ChangeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            String Mod = ModList.Text;
            switch (Mod)
            {
                case "Name":
                    break;
                case "Quantity":
                    bool isNumber = Char.IsNumber(e.KeyChar);
                    if (!isNumber)
                    {
                        e.Handled = true;
                        MessageBox.Show("Only numeric input is accepted");
                    }
                    break;
                case "Category":
                    break;
                case "Price":
                    bool isNumber2 = Char.IsNumber(e.KeyChar);
                    if (e.KeyChar == '.')
                    {
                        isNumber2 = !(sender as TextBox).Text.Contains(".");
                    }
                    if (!isNumber2)
                    {
                        e.Handled = true;
                        MessageBox.Show("Only numeric input is accepted");
                    }
                    break;
            }
        }

        private void IDboxMod_TextChanged(object sender, EventArgs e)
        {

        }
        private void ChangeBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Quantlab_Click(object sender, EventArgs e)
        {

        }
    }
}
