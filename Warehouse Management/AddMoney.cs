using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Warehouse_Management
{
    public partial class AddMoney : Form
    {
        private WarehouseApptest AddBalance;
        public double startbalance { get; set; }
        public int AccountID { get; set; }
        public string Username { get; set; }
        public string UserPass { get; set; }

        public AddMoney(WarehouseApptest addBalance)
        {
            InitializeComponent();
            this.AddBalance = addBalance;
        }
        private void AddMoney_Load_1(object sender, EventArgs e)
        {
            CurrentBalance.Text = Convert.ToString(startbalance);
        }

        private void CancelButtCanc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmButtBuy_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(MoneyAdd.Text);
            double total = amount + startbalance;
            AddBalance.Balance.Text = total.ToString();
            var items1 = new Changes();
            items1.BalanceChange(AccountID, amount);
            string[] arrLine = File.ReadAllLines("AccountList.txt");
            StringBuilder sb2 = new StringBuilder();
            sb2.Append(Username + " " + AccountID + " " + UserPass + " " + total);
            arrLine[AccountID - 1] = sb2.ToString();
            File.WriteAllLines("AccountList.txt", arrLine);
            this.Close();
        }

        private void MoneyAdd_KeyPress(object sender, KeyPressEventArgs e)
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
        private void MoneyAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDITEMLAB_Click(object sender, EventArgs e)
        {

        }
    }
}
