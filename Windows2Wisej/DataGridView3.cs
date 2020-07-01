using System;
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
    public partial class DataGridView3 : Form
    {

        // private DataGridView dataGridView1 = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource();

        public DataGridView3()
        {
            InitializeComponent();
        }

        private void chkColumnsVisible_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox aux = (CheckBox)sender;
            if (aux.Checked)
            {
                this.chkColumnsVisible.Text = "Columns visible";
            }
            else
            {
                this.chkColumnsVisible.Text = "Columns hidden";
            }

            int iColCount = dataGridView1.ColumnCount;

            if (dataGridView1.ColumnCount > 0)
            {
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.Visible = chkColumnsVisible.Checked;
                }
            }
        }

        private void chkShowDGWScroll_CheckedChanged(object sender, EventArgs e)
        {
            //TODO "possible bug when this setting is put"
            if (this.chkShowDGWScroll.Checked)
            {
                dataGridView1.ScrollBars = ScrollBars.Both;
            } else
            {
                dataGridView1.ScrollBars = ScrollBars.None;
            }
        }

        private void btnCreateColumns_Click(object sender, EventArgs e)
        {
            InitDataGrid();

            if (dataGridView1.ColumnCount > 0)
            {
                //DataGridViewColumn firstCol, lastCol;
                //firstCol = dataGridView1.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
                //lastCol = dataGridView1.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.Visible);

                //string strColIndexs = string.Concat("First ColIndex: ", firstCol.Index.ToString(),
                //                                    "Last ColIndex: ", lastCol.Index.ToString());

                //MessageBox.Show(strColIndexs);
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            int iColCount = dataGridView1.ColumnCount;

            if (iColCount > 0)
            {
                BindDataToDgw();
            }

        }


        #region "DataGrid code"

        private void BindDataToDgw()
        {
            //Datasource
            if (chkResetBindingSource.Checked)
            {
                dataGridView1.DataSource = null;
            }

            // Populate the data source.
            bindingSource1.Add(new Knight(Title.King, "Uther", true));
            bindingSource1.Add(new Knight(Title.King, "Arthur", true));
            bindingSource1.Add(new Knight(Title.Sir, "Mordred", false));
            bindingSource1.Add(new Knight(Title.Sir, "Gawain", true));
            bindingSource1.Add(new Knight(Title.Sir, "Galahad", true));

            if (dataGridView1.DataSource == null)
            {
                //Datasource
                dataGridView1.DataSource = bindingSource1;

            };

            if (chkAddSendData.Checked)
            {
                // Populate the data source.
                bindingSource1.Add(new Knight(Title.King, "+ Uther", true));
                bindingSource1.Add(new Knight(Title.King, "+ Arthur", true));
                bindingSource1.Add(new Knight(Title.Sir, "+ Mordred", false));
                bindingSource1.Add(new Knight(Title.Sir, "+ Gawain", true));
                bindingSource1.Add(new Knight(Title.Sir, "+ Galahad", true));
            }

        }

        private void InitDataGrid()
        {
            int intDatagridCols = dataGridView1.Columns.Count;

            if (intDatagridCols == 0)
            {
                //this.SuspendLayout();

                // A.- Initialize the DataGridView.
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.AutoSize = true;
                dataGridView1.Dock = DockStyle.Fill;

                dataGridView1.Columns.Add(CreateComboBoxWithEnums());

                // B.- Initialize and add a text box column.
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "Name";
                column.Name = "Knight-Col";
                dataGridView1.Columns.Add(column);

                // C.- Initialize and add a check box column.
                column = new DataGridViewCheckBoxColumn();
                column.DataPropertyName = "GoodGuy";
                column.Name = "Good-Col";
                dataGridView1.Columns.Add(column);

                this.panel1.Controls.Add(dataGridView1);
                //this.PerformLayout();
                //this.Refresh();
            }

        }

        DataGridViewComboBoxColumn CreateComboBoxWithEnums()
        {
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.DataSource = Enum.GetValues(typeof(Title));
            combo.DataPropertyName = "Title";
            combo.Name = "Title-Col";
            return combo;
        }

        #region "business object"
        private class Knight
        {
            private string hisName;
            private bool good;
            private Title hisTitle;

            public Knight(Title title, string name, bool good)
            {
                hisTitle = title;
                hisName = name;
                this.good = good;
            }

            public Knight()
            {
                hisTitle = Title.Sir;
                hisName = "<enter name>";
                good = true;
            }

            public string Name
            {
                get
                {
                    return hisName;
                }

                set
                {
                    hisName = value;
                }
            }

            public bool GoodGuy
            {
                get
                {
                    return good;
                }
                set
                {
                    good = value;
                }
            }

            public Title Title
            {
                get
                {
                    return hisTitle;
                }
                set
                {
                    hisTitle = value;
                }
            }
        }




        #endregion

        #endregion

       
    }
}
