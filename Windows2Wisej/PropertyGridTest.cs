using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// PropertyGrid classes for testing
using ClassesPropertyGridTest;

namespace Windows2Wisej
{
    public partial class PropertyGridTest : Form
    {
        public PropertyGridTest()
        {
            InitializeComponent();
        }

        private void btnTest1_Click(object sender, EventArgs e)
        {
            PropertyGridSimpleDemoClass gcd = new PropertyGridSimpleDemoClass();
            prpG.SelectedObject = gcd;
        }
    }
}
