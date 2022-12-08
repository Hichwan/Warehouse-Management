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
    public partial class WarehouseApptest : Form
    {

        public string Mod;
        public static string passingText;


        public WarehouseApptest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
            ItemTable.Rows.Add("Scapel Blade #10", 1, 1500, "Surgery", 1.50);
            ItemTable.Rows.Add("Medium Gloves", 2, 350, "General", 10);
            ItemTable.Rows.Add("3cc syringe", 3, 3000, "Surgery", 0.50);
            ItemTable.Rows.Add("Baytril 68mg Inj", 4, 150, "Medicine", 37);
            ItemTable.Rows.Add("LRS 500mL Bag", 5, 250, "Medicine", 50);
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
            PopoutAdd add = new PopoutAdd(this);
            add.Show();
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            PopoutDelete delete = new PopoutDelete(this);
            delete.Show();
        }

        private void Statement_SelectedIndexChanged(object sender, EventArgs e)
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
            var account1 = new Account();
            account1.Name = UsernameBox.Text;
            UsernameBox.Clear();
            account1.Password = PasswordBox.Text;
            PasswordBox.Clear();
            WelcomeBox.Text = "Welcome " + account1.Name + "!";
         }
    

        private void LogOutButt_Click(object sender, EventArgs e)
        {
            var account2 = new Account();
            UsernameBox.Text = string.Empty;
            account2.Name = "";
            PasswordBox.Text = string.Empty;
            account2.Password = "";
            WelcomeBox.Clear();
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            ModifyItems modify = new ModifyItems(this);
            modify.Show();
        }
    }
}
