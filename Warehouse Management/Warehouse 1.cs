using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

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
            string[] lines = File.ReadAllLines("Items List.txt");
            string[] values;

            for (int i = 0; i <lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];

                for (int j = 0; j< values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                ItemTable.Rows.Add(row);
            }
            ActionLog.Hide();
            AddItem.Hide();
            DeleteItem.Hide();
            ModifyButton.Hide();
            BuyItem.Enabled = false;
            AddMoney.Enabled = false;
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
            String statement = Statement.Text;
            StatementForm f2 = new StatementForm();
            f2.Month = statement;
            f2.Show();

        }

        private void BuyItem_Click(object sender, EventArgs e)
        {
            Popout1 f2 = new Popout1(this);
            f2.Show();
        }

        private void AddMoney_Click(object sender, EventArgs e)
        {
//            var account3 = new Account();
//            Double balance = Convert.ToDouble(account3.Balance);
            Double balance = Convert.ToDouble(Balance.Text);
            AddMoney f2 = new AddMoney(this);   
            f2.startbalance = balance;
            f2.Show();
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
            account1.getsAccounts();
            account1.Name = UsernameBox.Text;         
            account1.Password = PasswordBox.Text;
            if (Array.IndexOf(account1.users.ToArray(), account1.Name) == Array.IndexOf(account1.passwords.ToArray(), account1.Password))
            {
                WelcomeBox.Text = "Welcome " + account1.Name + "!";
                for( var i = 0; i < account1.users.Count; i++)
                {
                    if (account1.users[i] == account1.Name)
                    {
                        account1.Balance = account1.balance[i];
                        account1.UserID = account1.ID[i];
                    }
                }
                Balance.Text = account1.Balance;
                int accounttype = Convert.ToInt32(account1.UserID);
                if (accounttype <= 2)
                {
                    BuyItem.Enabled = true;
                    AddMoney.Enabled = true;
                }
                if (accounttype == 3)
                {
                    AddItem.Show();
                    DeleteItem.Show();
                    ModifyButton.Show();
                    BuyItem.Enabled = true;
                    AddMoney.Enabled = true;
                }
                else
                {
                    ActionLog.Show();
                    AddItem.Show();
                    DeleteItem.Show();
                    ModifyButton.Show();
                    BuyItem.Enabled = true;
                    AddMoney.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Wrong User or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UsernameBox.Clear();
            PasswordBox.Clear();
        }
    

        private void LogOutButt_Click(object sender, EventArgs e)
        {
            var account2 = new Account();
            UsernameBox.Text = string.Empty;
            account2.Name = "";
            PasswordBox.Text = string.Empty;
            account2.Password = "";
            account2.UserID = "";
            account2.Balance = "";
            Balance.Clear();
            WelcomeBox.Clear();
            ActionLog.Hide();
            AddItem.Hide();
            DeleteItem.Hide();
            ModifyButton.Hide();
            BuyItem.Enabled = false;
            AddMoney.Enabled = false;
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            ModifyItems modify = new ModifyItems(this);
            modify.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", "Action Log.txt");

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
