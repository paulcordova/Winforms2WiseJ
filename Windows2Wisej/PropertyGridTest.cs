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
            //prpG.SelectedObject = null;
            prpG.SelectedObject = gcd;
            lblTest.Text = "Test 1";
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            PropertyGridSimpleDemoClass2 gcd2 = new PropertyGridSimpleDemoClass2();
            //prpG.SelectedObject = null;
            prpG.SelectedObject = gcd2;
            lblTest.Text = "Test 2";
        }

        private void btnTest3_Click(object sender, EventArgs e)
        {
            PropertyGridSimpleDemoClass3 gcd3 = new PropertyGridSimpleDemoClass3();
            //prpG.SelectedObject = null;
            prpG.SelectedObject = gcd3;
            lblTest.Text = "Test 3";
        }

        private void btnTest4_Click(object sender, EventArgs e)
        {
            DrinkerDoses gcd4 = new DrinkerDoses();
            //prpG.SelectedObject = null;
            prpG.SelectedObject = gcd4;
            lblTest.Text = "Test 4";
        }

        private void btnTest5_Click(object sender, EventArgs e)
        {
            GameClassDisplayer gcd5 = new GameClassDisplayer();
            prpG.SelectedObject = null;
            prpG.SelectedObject = gcd5;
            lblTest.Text = "Test 5";
        }
    }
}
