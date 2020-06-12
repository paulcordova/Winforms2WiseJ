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
    public partial class FocusTest : Form
    {
        public FocusTest()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = ((Control)sender).Text == "A";
        }

        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = ((Control)sender).Text == "A";
        }

        private void comboBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = ((Control)sender).Text == "A";
        }

        private void dateTimePicker1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //e.Cancel = ((Control)sender).Text == "martes, 2 de agosto de 2016";
            e.Cancel = ((Control)sender).Text == "Tuesday, August 2, 2016";


        }

        private void button1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = this.textBox1.Text == "B";

            if (e.Cancel)
            {
                ((Control)sender).Text = " ERR";
            }
            else
            {
                ((Control)sender).Text = "button1";
            }

        }

        private void numericUpDown1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = ((Control)sender).Text == "1";

        }

        private void listBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = ((Control)sender).Text == "One";
        }
    }
}
