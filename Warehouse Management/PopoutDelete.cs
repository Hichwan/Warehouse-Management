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
        public PopoutDelete()
        {
            InitializeComponent();
        }

        private void CancelButtDel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
