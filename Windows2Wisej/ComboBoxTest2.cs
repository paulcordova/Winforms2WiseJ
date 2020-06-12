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
    public partial class ComboBoxTest2 : Form
    {
        public ComboBoxTest2()
        {
            InitializeComponent();
            InitializeComponent2();
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

        private void InitializeComponent2()
        {
            this.SuspendLayout();
            // 
            // ComboBoxTest2
            // 
            this.ClientSize = new System.Drawing.Size(479, 261);
            this.Name = "ComboBoxTest2";
            this.ResumeLayout(false);

        }
    }
}
