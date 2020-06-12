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
using Windows2Wisej.ClassesPropertyGrid;
using System.Dynamic;

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

        private void button1_Click(object sender, EventArgs e)
        {
            // Creating a dynamic dictionary.
            dynamic person = new DynamicDictionary();

            // Adding new dynamic properties.
            // The TrySetMember method is called.
            person.FirstName = "Ellen";
            person.LastName = "Adams";
            person.Age = 45;

            prpG.SelectedObject = person;

            lblTest.Text = "Test 6 Dynamic Obj with 3 properties";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dynamic _employee = new DynamicBusinessObject();

            _employee.FirstName = "John";
            _employee.LastName = "Doe";
            _employee.Test = "This is a test";
            _employee.height = decimal.Parse("1.80");
            _employee.DateOfBirdth = DateTime.Parse("07/11/1977");

            prpG.SelectedObject = _employee;

            lblTest.Text = "Test 7 Dynamic Obj";
        }
    }
}
