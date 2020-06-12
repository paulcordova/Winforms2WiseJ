using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows2Wisej
{
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        private void btnAddColumns_Click(object sender, EventArgs e)
        {
            //Add columns
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Position";
            label2.Text = dataGridView1.Columns[0].HeaderText;

            dataGridView1.Columns[1].Name = "Teams";
            label3.Text = dataGridView1.Columns[1].HeaderText;

            dataGridView1.Columns[2].Name = "Points";
            label4.Text = dataGridView1.Columns[2].HeaderText;

            dataGridView1.Columns[3].Name = "Games";
            label5.Text = dataGridView1.Columns[3].HeaderText;
        }

        private void btnClearColumns_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns.RemoveAt(3);
                dataGridView1.Columns.RemoveAt(2);
                dataGridView1.Columns.RemoveAt(1);
                dataGridView1.Columns.RemoveAt(0);

            }

        }

        private void btnAddRows_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 4)
            {
                //Add Rows
                ArrayList row = new ArrayList();

                row.Add("1");
                row.Add("Man Utd");
                row.Add("87");
                row.Add("38");
                dataGridView1.Rows.Add(row.ToArray());

                //2nd row
                row = new ArrayList();
                row.Add("2");
                row.Add("Chelsea");
                row.Add("82");
                row.Add("38");
                dataGridView1.Rows.Add(row.ToArray());

                //3rd row
                row = new ArrayList();
                row.Add("1");
                row.Add("Arsenal");
                row.Add("78");
                row.Add("38");
                dataGridView1.Rows.Add(row.ToArray());

                //4rd row
                row = new ArrayList();
                row.Add("1");
                row.Add("Arsenal");
                row.Add("78");
                row.Add("38");
                dataGridView1.Rows.Add(row.ToArray());

            }
        }

        private void btnClearRows_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Rows.RemoveAt(3);
                dataGridView1.Rows.RemoveAt(2);
                dataGridView1.Rows.RemoveAt(1);
                dataGridView1.Rows.RemoveAt(0);

                label2.Text = "*";
                label3.Text = "*";
                label4.Text = "*";
                label5.Text = "*";


            }
        }
    }
}
