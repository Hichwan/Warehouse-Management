using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Management
{
    public partial class ModifyItems : Form
    {
        private WarehouseApptest ModItem;
        int modifier;

        
        public ModifyItems(WarehouseApptest modify)
        {
            InitializeComponent();
            this.ModItem = modify;
        }
  
        private void Quantlab_Click(object sender, EventArgs e)
        {

        }

        private void CancelButtCanc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {




        }

        private void IDboxMod_TextChanged(object sender, EventArgs e)
        {

        }
        private void ModList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Mod = ModList.Text;
            switch (Mod)
            {
                case "Name":
                    modifier = 1;
                    break;
                case "Quantity":
                    modifier = 2;
                    break;
                case "Category":
                    modifier = 3;
                    break;
                case "Price":
                    modifier = 4;
                    break;
            }
        }
        private void ConfirmButtBuy_Click(object sender, EventArgs e)
        {

            int ChangeID = Int32.Parse(IDboxMod.Text);
                    for (int i = ModItem.ItemTable.Rows.Count-1; i >= 0; i--)
                    {
                        DataGridViewRow row = ModItem.ItemTable.Rows[i];
                        int rowID = Convert.ToInt32(row.Cells[1].Value);
                        if (rowID == ChangeID)
                        {
                    using (StreamWriter sw = new StreamWriter("Action log.txt", append: true))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Modified" + " " + ModList.Text + " " + "For Item ID" + " " + row.Cells[1].Value.ToString() + " From: " + row.Cells[modifier].Value.ToString()  + " To: " + ChangeBox.Text);
                        sw.WriteLine(sb.ToString());
                    }
                    row.Cells[modifier].Value = ChangeBox.Text;
                    
                }
                    }
            IDboxMod.Clear();
            ChangeBox.Clear();
        }


    }
}
