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
    public partial class GroupBox : Form
    {
        public GroupBox()
        {
            InitializeComponent();
            this.button2.Click += button2_Click;
        }


        void button2_Click(object sender, EventArgs e)
        {
            this.groupBox1.Height = 400;
            this.groupBox1.Width = 200;


        }
    }
}
