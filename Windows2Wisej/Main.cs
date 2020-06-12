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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void button17_Click(object sender, EventArgs e)
        {
            //new  ListViewVirtualModeTest().Show(this);

            ListViewVirtualModeTest newMDIChild = new ListViewVirtualModeTest();
            newMDIChild.StartPosition = FormStartPosition.CenterParent;
            newMDIChild.ShowDialog();
        }
               

        private void ListBox_Click(object sender, EventArgs e)
        {
            // new ListBoxTest().Show();
            ListBoxTest newMDIChild = new ListBoxTest();
            newMDIChild.StartPosition = FormStartPosition.CenterParent;
            newMDIChild.ShowDialog();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //new ComboBoxTest2().Show();

            ComboBoxTest2 newMDIChild = new ComboBoxTest2();
            newMDIChild.StartPosition = FormStartPosition.CenterParent;
            newMDIChild.ShowDialog();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // new CheckedListBoxTest().Show();

            CheckedListBoxTest newMDIChild = new CheckedListBoxTest();
            newMDIChild.StartPosition = FormStartPosition.CenterParent;
            newMDIChild.ShowDialog();

        }
    }
}
