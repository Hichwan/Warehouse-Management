﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Management
{
    public partial class WarehouseApp : Form
    {




        public WarehouseApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            PopoutAdd add = new PopoutAdd();
            add.Show();
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            PopoutDelete delete = new PopoutDelete();
            delete.Show();
        }

        private void Statement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModifyItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BuyItem_Click(object sender, EventArgs e)
        {
            Popout1 f2 = new Popout1();
            f2.Show();
        }

        private void AddMoney_Click(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void LogInButt_Click(object sender, EventArgs e)
        {
            Account.Name = UsernameBox.Text;
            UsernameBox.Clear();
            Account.Password = PasswordBox.Text;
            PasswordBox.Clear();
            WelcomeBox.Text = "Welcome" + Account.Name;
         }
    

        private void LogOutButt_Click(object sender, EventArgs e)
        {
            UsernameBox.Text = string.Empty;
            Account.Name = "";
            PasswordBox.Text = string.Empty;
            Account.Password = "";
        }
    }
}