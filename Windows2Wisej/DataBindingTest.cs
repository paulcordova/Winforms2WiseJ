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
    public partial class DataBindingTest : Form
    {
        private DataSet dsSource = new DataSet();
        public DataBindingTest()
        {
            InitializeComponent();
        }

        private void DataBindingTest_Load(object sender, EventArgs e)
        {
            //Fill the DataSet
            this.FillDataSet();

            //Bind the controls
            this.BindControls();
        }

        private void FillDataSet()
        {
            //Create a new DataTable in the DataSet
            dsSource.Tables.Add("sites");
            dsSource.Tables["sites"].Columns.Add("url", Type.GetType("System.String"));
            dsSource.Tables["sites"].Columns.Add("name", Type.GetType("System.String"));
            dsSource.Tables["sites"].Columns.Add("icon", typeof(byte[]));

            //Create a few rows and add them to the DataTable
            DataRow tempRow = dsSource.Tables["sites"].NewRow();
            tempRow["url"] = "http://www.gotmono.com";
            tempRow["name"] = "Mono Community Page";
            //tempRow["icon"] = "icon-print";
            dsSource.Tables["sites"].Rows.Add(tempRow);

            tempRow = dsSource.Tables["sites"].NewRow();
            tempRow["url"] = "http://www.go-mono.com/tutorial";
            tempRow["name"] = "The Mono Handbook";

            Image img = System.Drawing.Image.FromFile(Application.StartupPath + "\\lv_images\\32x32\\disks.png");
            tempRow["icon"] = imageToByteArray(img);
            //tempRow["icon"] = System.Drawing.Image.FromFile(Application.StartupPath + "\\lv_images\\32x32\\disks.png");

            dsSource.Tables["sites"].Rows.Add(tempRow);

            tempRow = dsSource.Tables["sites"].NewRow();
            tempRow["url"] = "http://www.go-mono.com";
            tempRow["name"] = "Mono Homepage";
            img = System.Drawing.Image.FromFile(Application.StartupPath + "\\lv_images\\32x32\\evolution.png");
            tempRow["icon"] = imageToByteArray(img);
            //tempRow["icon"] = System.Drawing.Image.FromFile(Application.StartupPath + "\\lv_images\\32x32\\evolution.png");
            dsSource.Tables["sites"].Rows.Add(tempRow);

            tempRow = dsSource.Tables["sites"].NewRow();
            tempRow["url"] = "http://www.nullenvoid.com/mono/wiki/index.php/WineSamples";
            tempRow["name"] = "Mono WineSamples";
            //tempRow["icon"] = "window-icon?color=red";

            dsSource.Tables["sites"].Rows.Add(tempRow);
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void BindControls()
        {
            //Bind the listBox
            listBox1.DataSource = dsSource.Tables["sites"];
            listBox1.DisplayMember = "name";
            listBox1.ValueMember = "url";
            //Not in Winforms
            //listBox1.IconMember = "icon";

            //Bind the ComboBox
            comboBox1.DataSource = dsSource.Tables["sites"];
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "url";
            //Not in Winforms
            //comboBox1.IconMember = "icon";

            //Bind the DataGrid to the DataSet
            dataGrid.DataSource = dsSource.Tables["sites"]; ;

            //Bind the second DataGrid to the DataSet
            dataGrid2.DataSource = dsSource.Tables["sites"];

            //Bind the Textboxes to the selected row
            textBox.DataBindings.Add("text", dsSource.Tables["sites"], "name");
            textBox2.DataBindings.Add("text", dsSource.Tables["sites"], "url");

        }


    }
}
