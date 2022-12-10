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
        public AddMoney(WarehouseApptest addBalance)
        {
            InitializeComponent();
            this.AddBalance = addBalance;
        }
        private void AddMoney_Load_1(object sender, EventArgs e)
        {
            CurrentBalance.Text = Convert.ToString(startbalance);
        }

        private void IDITEMLAB_Click(object sender, EventArgs e)
        {

        }

        private void CancelButtCanc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MoneyAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmButtBuy_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(MoneyAdd.Text);
            double total = amount + startbalance;
            AddBalance.Balance.Text = total.ToString();
            using (StreamWriter sw = new StreamWriter("Action log.txt", append: true))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Added: " + amount + " to account.");
                sw.WriteLine(sb.ToString());
            }
            this.Close();
        }


    }
}
