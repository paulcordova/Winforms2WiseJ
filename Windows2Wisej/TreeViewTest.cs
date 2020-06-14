﻿using System;
using System.Collections;
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
    public partial class TreeViewTest : Form
    {
        // Test2 Create a new ArrayList to hold the Customer objects.
        private ArrayList customerArray = new ArrayList();

        public TreeViewTest()
        {
            
            InitializeComponent();
        }

        #region ButtonsClick
        private void btnTest1_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes != null)
            {
                treeView1.Nodes.Clear();
            }
            Test1_InitializeTreeView();
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count > 0)
            {
                treeView1.Nodes.Clear();
            }
            Test2_FillMyTreeView();
        }

        #endregion

        #region Test1 TreeView Init
        // Populates a TreeView control with example nodes. 
        private void Test1_InitializeTreeView()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Parent");
            treeView1.Nodes[0].Nodes.Add("Child 1");
            treeView1.Nodes[0].Nodes.Add("Child 2");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Grandchild");
            treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Great Grandchild");
            treeView1.EndUpdate();
        }


        #endregion

        #region Test2 TreeView Init

        private void Test2_FillMyTreeView()
        {
            // Add customers to the ArrayList of Customer objects.
            for (int x = 0; x < 1000; x++)
            {
                customerArray.Add(new Customer("Customer" + x.ToString()));
            }

            // Add orders to each Customer object in the ArrayList.
            foreach (Customer customer1 in customerArray)
            {
                for (int y = 0; y < 15; y++)
                {
                    customer1.CustomerOrders.Add(new Order("Order" + y.ToString()));
                }
            }

            // Display a wait cursor while the TreeNodes are being created.
            //Cursor.Current = new Cursor("MyWait.cur");
            Cursor.Current = Cursors.WaitCursor;

            // Suppress repainting the TreeView until all the objects have been created.
            treeView1.BeginUpdate();

            // Clear the TreeView each time the method is called.
            treeView1.Nodes.Clear();

            // Add a root TreeNode for each Customer object in the ArrayList.
            foreach (Customer customer2 in customerArray)
            {
                treeView1.Nodes.Add(new TreeNode(customer2.CustomerName));

                // Add a child treenode for each Order object in the current Customer object.
                foreach (Order order1 in customer2.CustomerOrders)
                {
                    treeView1.Nodes[customerArray.IndexOf(customer2)].Nodes.Add(
                      new TreeNode(customer2.CustomerName + "." + order1.OrderID));
                }
            }

            // Reset the cursor to the default for all controls.
            Cursor.Current = Cursors.Default;

            // Begin repainting the TreeView.
            treeView1.EndUpdate();
        }

        #endregion


    }

    #region Test2 Utils

    // The basic Customer class.
    public class Customer : System.Object
    {
        private string custName = "";
        protected ArrayList custOrders = new ArrayList();

        public Customer(string customername)
        {
            this.custName = customername;
        }

        public string CustomerName
        {
            get { return this.custName; }
            set { this.custName = value; }
        }

        public ArrayList CustomerOrders
        {
            get { return this.custOrders; }
        }
    } // End Customer class 

    // The basic customer Order class.
    public class Order : System.Object
    {
        private string ordID = "";

        public Order(string orderid)
        {
            this.ordID = orderid;
        }

        public string OrderID
        {
            get { return this.ordID; }
            set { this.ordID = value; }
        }
    } // End Order class


    #endregion


}
