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

        private void button1_Click(object sender, EventArgs e)
        {
            //new ComboBoxTest1().Show();

            ComboBoxTest1 newMDIChild = new ComboBoxTest1();
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

        private void buttonGroupBox_Click(object sender, EventArgs e)
        {
            GroupBox newMDIChild = new GroupBox();
            newMDIChild.StartPosition = FormStartPosition.CenterParent;
            newMDIChild.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //new ListBoxTest2().Show();
            ListBoxTest2 newMDIChild = new ListBoxTest2();
            newMDIChild.StartPosition = FormStartPosition.CenterParent;
            newMDIChild.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FocusTest newMDIChild = new FocusTest();
            newMDIChild.StartPosition = FormStartPosition.CenterParent;
            newMDIChild.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridView newMDIChild = new DataGridView();
            newMDIChild.StartPosition = FormStartPosition.CenterParent;
            newMDIChild.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridView2 newMDIChild = new DataGridView2();
            newMDIChild.StartPosition = FormStartPosition.CenterParent;
            newMDIChild.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PropertyGridTest validationPropGrid = new PropertyGridTest();
            validationPropGrid.StartPosition = FormStartPosition.CenterParent;
            validationPropGrid.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TreeViewTest validationTreeView = new TreeViewTest();
            validationTreeView.StartPosition = FormStartPosition.CenterParent;
            validationTreeView.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmContacts frm = new frmContacts();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void btnDataBinding_Click(object sender, EventArgs e)
        {

            DataBindingTest frm = new DataBindingTest();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataGridView3 newMDIChild = new DataGridView3();
            newMDIChild.StartPosition = FormStartPosition.CenterParent;
            newMDIChild.ShowDialog();
        }
    }
}
