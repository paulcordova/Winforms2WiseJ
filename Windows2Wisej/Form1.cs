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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            comboBox.Items.Clear();
        }

        private void AddItems_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                comboBox.Items.Add("Item " + last_item);
                last_item++;
            }
        }

        private void Simple_Click(object sender, EventArgs e)
        {
            comboBox.DropDownStyle = ComboBoxStyle.Simple;
        }
    }
}
