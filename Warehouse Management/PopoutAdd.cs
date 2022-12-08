﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Management
{
    public partial class PopoutAdd : Form
    {
        private WarehouseApptest items;
        int IDcount = 6;

        public PopoutAdd(WarehouseApptest fg)
        {
            InitializeComponent();
            this.items = fg;
        }

        private void CancelButtAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmButtAdd_Click(object sender, EventArgs e)
        {
            for (int i = items.ItemTable.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = items.ItemTable.Rows[i];
                int rowID = Convert.ToInt32(row.Cells[1].Value);
                if (rowID == IDcount)
                {
                    IDcount++;
                }
            }
            items.ItemTable.Rows.Add(NameItemAdd.Text, IDcount.ToString(), QuantityNew.Text, CatNew.Text, CostNew.Text);
        }

        private void IDboxBuy_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuantityNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isNumber = Char.IsNumber(e.KeyChar);
            if (!isNumber)
            {
                e.Handled = true;
                MessageBox.Show("Only numeric input is accepted");
            }
        }

        private void CostNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isNumber = Char.IsNumber(e.KeyChar);
            if (e.KeyChar == '.')
            {
                isNumber = !(sender as TextBox).Text.Contains(".");
            }
            if (!isNumber)
            {
                e.Handled = true;
                MessageBox.Show("Only numeric input is accepted");
            }

        }
    }
}
