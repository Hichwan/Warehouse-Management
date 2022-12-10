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
    public partial class StatementForm : Form
    {
        public string Month { get; set; }
        public StatementForm()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {

            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Price", typeof(double));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Total Cost", typeof(double));

            StatementGrid.DataSource = table;
            switch (this.Month)
            {
                case "December":
                    string[] lines = File.ReadAllLines("December.txt");
                    string[] values;

                    for (int i = 0; i < lines.Length; i++)
                    {
                        values = lines[i].ToString().Split(',');
                        string[] row = new string[values.Length];

                        for (int j = 0; j < values.Length; j++)
                        {
                            row[j] = values[j].Trim();
                        }
                        table.Rows.Add(row);
                    }
                    break;
                case "November":
                    string[] lines2 = File.ReadAllLines("November.txt");
                    string[] values2;
                    for (int i = 0; i < lines2.Length; i++)
                    {
                        values2 = lines2[i].ToString().Split(',');
                        string[] row = new string[values2.Length];

                        for (int j = 0; j < values2.Length; j++)
                        {
                            row[j] = values2[j].Trim();
                        }
                        table.Rows.Add(row);
                    }
                    break;
                case "October":
                    string[] lines3 = File.ReadAllLines("October.txt");
                    string[] values3;
                    for (int i = 0; i < lines3.Length; i++)
                    {
                        values3 = lines3[i].ToString().Split(',');
                        string[] row = new string[values3.Length];

                        for (int j = 0; j < values3.Length; j++)
                        {
                            row[j] = values3[j].Trim();
                        }
                        table.Rows.Add(row);
                    }
                    break;
            }
            
 

        }

        private void StatementGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
