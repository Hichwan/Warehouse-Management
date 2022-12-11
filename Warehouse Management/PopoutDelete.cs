using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Warehouse_Management
{
    public partial class PopoutDelete : Form
    {
        private WarehouseApptest DeleteRow;
        int DeleteId;
        public int AccountID { get; set; }
        public PopoutDelete(WarehouseApptest deleterow)
        {
            InitializeComponent();
            this.DeleteRow = deleterow;
        }

        private void CancelButtDel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmButtDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDboxDel.Text))
            {
                MessageBox.Show("Error No Value Placed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DeleteRow.ItemTable.Sort(DeleteRow.ItemTable.Columns[1], ListSortDirection.Ascending);
                DeleteId = Int32.Parse(IDboxDel.Text);
                for (int i = DeleteRow.ItemTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = DeleteRow.ItemTable.Rows[i];
                    int rowID = Convert.ToInt32(row.Cells[1].Value);
                    if (rowID == DeleteId)
                    {
                        var items1 = new Changes();
                        items1.DeleteChange(AccountID, row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[1].Value), Convert.ToInt32(row.Cells[2].Value), row.Cells[3].Value.ToString(), Convert.ToDouble(row.Cells[4].Value));
                        DeleteRow.ItemTable.Rows.RemoveAt(i);
                        items1.DeleteChange(DeleteId);                        
                        DeleteRow.ItemTable.Sort(DeleteRow.ItemTable.Columns[1], ListSortDirection.Ascending);
                    }
                }
                IDboxDel.Clear();
            }
        }

        private void IDboxDel_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isNumber = Char.IsNumber(e.KeyChar);
            if (!isNumber)
            {
                e.Handled = true;
                MessageBox.Show("Only numeric input is accepted");
            }
        }
        private void IDboxDel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
