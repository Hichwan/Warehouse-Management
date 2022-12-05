using System;
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
        private WarehouseApp items;
        int IDcount = 1;
        public PopoutAdd(WarehouseApp fg)
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
            
            items.ItemTable.Rows.Add(NameItemAdd.Text, IDcount.ToString(), QuantityNew.Text, CatNew.Text, CostNew.Text);
            IDcount++;
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
    }
}
