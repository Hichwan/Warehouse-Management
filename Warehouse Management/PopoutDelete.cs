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
    public partial class PopoutDelete : Form
    {
        private WarehouseApp DeleteRow;
        int DeleteId;
        public PopoutDelete(WarehouseApp _deleterow)
        {
            InitializeComponent();
            this.DeleteRow = _deleterow;
        }

        private void CancelButtDel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IDboxDel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ConfirmButtDel_Click(object sender, EventArgs e)
        {
            DeleteId = Int32.Parse(IDboxDel.Text);
            for( int i = DeleteRow.ItemTable.Rows.Count-1; i >= 0; i--)
            {
                DataGridViewRow row = DeleteRow.ItemTable.Rows[i];
                int rowID = Convert.ToInt32(row.Cells[1].Value);
                if (rowID == DeleteId)
                {
                    DeleteRow.ItemTable.Rows.RemoveAt(i);
                }
            }
        }
    }
}
