using System;
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

        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void Statement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModifyItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BuyItem_Click(object sender, EventArgs e)
        {

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
            Account.Password = PasswordBox.Text;
         }
    

        private void LogOutButt_Click(object sender, EventArgs e)
        {

        }

        private void UsernameBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
