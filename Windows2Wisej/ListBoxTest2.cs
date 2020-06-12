﻿using System;
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
    public partial class ListBoxTest2 : Form
    {

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListBox listBox5;
        private ListBox listBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label labelSel;
        private Button buttonAdd;
        private Button buttonClear;
        private Label labelitems;
        private int last_item = 0;

        public ListBoxTest2()
        {
            InitializeComponent();

            InitializeComponent2();
        }

        void InitializeComponent2()
        {
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            listBox5 = new ListBox();
            listBox6 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            labelSel = new Label();
            buttonAdd = new Button();
            buttonClear = new Button();
            labelitems = new Label();

            SuspendLayout();

            int y = 0;

            object[] items = new object[] {
                "this is item 0",
                "this is item 1",
                "this is item 2",
                "this is item 3",
                "this is item 4",
                "this is item 5",
                "this is item 6",
				//"this is item 6 this is really long item as a matter of fact that I may be longer that you expect",
				"this is item 7",
                "this is item 8",
                "this is item 9",
                "this is item 10",
                "this is item 11",
                "this is item 12",
                "this is item 13",
                "this is item 14",
                "this is item 15",
                "this is item 16",
                "this is item 17",
            };

            object[] items_comarques = new object[]
            {
                "Conca de Barberà", "Vallès Occidental", "Ripollès",
                "Alt Urgell", "Alta Ribagorça",
                "Anoia", "Bages", "Baix Empordà", "Baix Llobregat",
                "Baix Penedès", "Barcelonès",
                "Berguedà", "Cerdanya", "Garraf", "Garrigues",
                "Montsià", "Noguera", "Osona", "Pallars Jussà", "Pla d'Urgell",
                "Priorat", "Ribera d'Ebre", "Alt Penedès",
                "Segarra", "Segrià", "Selva", "Solsonès", "Tarragonès",
                "Garrotxa", "Gironès", "Maresme", "Pallars Sobirà",
                "Terra Alta", "Baix Camp", "Baix Ebre", "Urgell", "Val d'Aran",
                "Vallès Oriental", "Alt Empordà", "Alt Camp",
            };

            bool listbox1 = true;
            bool listbox2 = true;
            bool listbox3 = true;
            bool listbox4 = true;
            bool listbox5 = true;
            bool listbox6 = true;


            //
            // listBox 1
            //
            if (listbox1)
            {
                listBox1.Location = new System.Drawing.Point(10, y + 20);
                listBox1.SelectionMode = SelectionMode.One;
                listBox1.Size = new System.Drawing.Size(400, 65);
                listBox1.ScrollAlwaysVisible = false;
                listBox1.HorizontalScrollbar = false;
                listBox1.Items.AddRange(items);
                listBox1.SelectedIndexChanged += new System.EventHandler(IndexChangedListBox1);

                listBox1.SelectedIndex = 1;
                listBox1.SelectedIndex = 2;

                label1.Location = new System.Drawing.Point(10, y);
                label1.AutoSize = true;
                label1.Text = "MultiColumn: false" + " Selection:" + listBox1.SelectionMode;
            }


            //
            // listBox 2
            //
            if (listbox2)
            {
                listBox2.Location = new System.Drawing.Point(450, y + 20);
                listBox2.Size = new System.Drawing.Size(400, 65);
                listBox2.ScrollAlwaysVisible = false;
                listBox2.HorizontalScrollbar = false;
                listBox2.SelectionMode = SelectionMode.MultiSimple;
                listBox2.Items.AddRange(items);
                listBox2.SelectedIndex = 1;
                listBox2.SelectedIndex = 2;
                listBox2.SelectedIndexChanged += new System.EventHandler(IndexChangedListBox2);
                label2.Location = new System.Drawing.Point(450, y);
                label2.AutoSize = true;
                label2.Text = "MultiColumn: false" + " Selection:" + listBox2.SelectionMode;
            }

            y += 120;

            //
            // listBox 3
            //
            if (listbox3)
            {
                listBox3.Location = new System.Drawing.Point(10, y + 20);
                listBox3.SelectionMode = SelectionMode.MultiExtended;
                listBox3.Size = new System.Drawing.Size(400, 65);
                listBox3.ScrollAlwaysVisible = false;
                listBox3.HorizontalScrollbar = true;
                listBox3.Items.AddRange(items);
                listBox3.SelectedIndexChanged += new System.EventHandler(IndexChangedListBox3);
                listBox3.SelectedIndex = 1;
                listBox3.SelectedIndex = 2;
                listBox3.RightToLeft = RightToLeft.Yes;
                label3.Location = new System.Drawing.Point(10, y);
                label3.AutoSize = true;
                label3.Text = "MultiColumn: false" + " Selection:" + listBox3.SelectionMode;
            }

            //
            // listBox 4
            //
            if (listbox4)
            {
                listBox4.Location = new System.Drawing.Point(450, y + 20);
                listBox4.RightToLeft = RightToLeft.Yes;
                listBox4.SelectionMode = SelectionMode.One;
                listBox4.Size = new System.Drawing.Size(400, 65);
                listBox4.ScrollAlwaysVisible = false;
                listBox4.HorizontalScrollbar = true;
                listBox4.Items.AddRange(items);
                listBox4.SelectedIndexChanged += new System.EventHandler(IndexChangedListBox4);
                label4.Location = new System.Drawing.Point(450, y);
                label4.AutoSize = true;
                label4.Text = "MultiColumn: false" + " Selection:" + listBox4.SelectionMode;

                listBox4.SelectedItem = listBox4.Items[4];
            }

            y += 120;

            //
            // listBox 5
            //
            if (listbox5)
            {

                Console.WriteLine("ListBox {0}", listBox5.Text);

                listBox5.Location = new System.Drawing.Point(10, y + 20);
                listBox5.SelectionMode = SelectionMode.MultiSimple;
                listBox5.Size = new System.Drawing.Size(400, 70);
                listBox5.ScrollAlwaysVisible = false;
                listBox5.HorizontalScrollbar = false;
                listBox5.Items.AddRange(items_comarques);
                listBox5.Text = listBox5.Items[5].ToString();
                listBox5.SelectedIndexChanged += new System.EventHandler(IndexChangedListBox5);
                listBox5.Sorted = true;
                label5.Location = new System.Drawing.Point(10, y);
                label5.AutoSize = true;
                label5.Text = "MultiColumn: false" + " Selection:" + listBox5.SelectionMode;


                Console.WriteLine("ListBox {0}", listBox5.Text);
            }

            //
            // listBox 6
            //
            if (listbox6)
            {
                listBox6.Location = new System.Drawing.Point(450, y + 20);
                listBox6.Sorted = true;
                listBox6.SelectionMode = SelectionMode.MultiExtended;
                listBox6.Size = new System.Drawing.Size(400, 70);
                listBox6.ScrollAlwaysVisible = false;
                listBox6.HorizontalScrollbar = false;
                listBox6.Items.AddRange(items_comarques);
                listBox6.SelectedIndexChanged += new System.EventHandler(IndexChangedListBox6);
                label6.Location = new System.Drawing.Point(450, y);
                label6.AutoSize = true;
                label6.Text = "MultiColumn: false" + " Selection:" + listBox6.SelectionMode;
            }

            y += 120;
            labelSel.Location = new System.Drawing.Point(10, y);
            labelSel.AutoSize = true;
            labelSel.Text = "Seleteced Items None";

            buttonAdd.Location = new Point(860, 30);
            buttonAdd.Name = "button";
            buttonAdd.Size = new System.Drawing.Size(75, 25);
            buttonAdd.Text = "Add Items";
            buttonAdd.Click += new System.EventHandler(ButtonAddClick);

            buttonClear.Location = new Point(860, 300);
            buttonClear.Name = "button";
            buttonClear.Size = new System.Drawing.Size(90, 25);
            buttonClear.Text = "Clear Sel Items";
            buttonClear.Click += new System.EventHandler(ButtonClearClick);

            labelitems.Location = new Point(860, 60);
            labelitems.Text = "items:" + listBox1.Items.Count;

            //
            // MainForm
            //
            ClientSize = new System.Drawing.Size(950, 500);

            if (listbox1)
                Controls.AddRange(new Control[] { listBox1, label1 });

            if (listbox2)
                Controls.AddRange(new Control[] { listBox2, label2 });

            if (listbox3)
                Controls.AddRange(new Control[] { listBox3, label3 });

            if (listbox4)
                Controls.AddRange(new Control[] { listBox4, label4 });

            if (listbox5)
                Controls.AddRange(new Control[] { listBox5, label5 });

            if (listbox6)
                Controls.AddRange(new Control[] { listBox6, label6 });

            Controls.Add(buttonAdd);
            Controls.Add(labelitems);
            Controls.Add(labelSel);
            Controls.Add(buttonClear);

            Text = "SWF-Listboxes";
            ResumeLayout(false);

        }

        void ButtonAddClick(object sender, System.EventArgs e)
        {
            string item_text;
            int last = last_item;

            for (int i = last_item; i < last + 10; i++)
            {
                item_text = "New item " + last_item;
                listBox1.Items.Add(item_text);
                listBox2.Items.Add(item_text);
                listBox3.Items.Add(item_text);
                listBox4.Items.Add(item_text);
                listBox5.Items.Add(item_text);
                listBox6.Items.Add(item_text);
                last_item++;
            }

            labelitems.Text = "items:" + listBox1.Items.Count;
        }

        void ButtonClearClick(object sender, System.EventArgs e)
        {
            listBox1.ClearSelected();
            listBox2.ClearSelected();
            listBox3.ClearSelected();
            listBox4.ClearSelected();
            listBox5.ClearSelected();
            listBox6.ClearSelected();

        }

        string DumpElements(ListBox listbox)
        {
            string str;
            str = " SelectedIndices ";

            if (listbox.SelectionMode == SelectionMode.One)
            {
                str += "" + listbox.SelectedIndex + ";";
            }
            else
            {
                for (int i = 0; i < listbox.SelectedIndices.Count; i++)
                {
                    str += "" + listbox.SelectedIndices[i];
                    str += ";";
                }
            }

            str += " - SelectedObjects ";

            if (listbox.SelectionMode == SelectionMode.One)
            {
                str += "" + listbox.SelectedItem + ";";
            }
            else
            {
                for (int i = 0; i < listbox.SelectedItems.Count; i++)
                {
                    str += "" + listbox.SelectedItems[i];
                    str += ";";
                }
            }

            str += " - SelectedIndex ";
            str += listbox.SelectedIndex;

            return str;
        }

        void IndexChangedListBox1(object sender, System.EventArgs e)
        {
            labelSel.Text = "ListBox1" + DumpElements((ListBox)sender);
        }

        void IndexChangedListBox2(object sender, System.EventArgs e)
        {
            labelSel.Text = "ListBox2" + DumpElements((ListBox)sender);
        }

        void IndexChangedListBox3(object sender, System.EventArgs e)
        {
            labelSel.Text = "ListBox3" + DumpElements((ListBox)sender);
        }

        void IndexChangedListBox4(object sender, System.EventArgs e)
        {
            labelSel.Text = "ListBox4" + DumpElements((ListBox)sender);
        }

        void IndexChangedListBox5(object sender, System.EventArgs e)
        {
            labelSel.Text = "ListBox5" + DumpElements((ListBox)sender);
        }

        void IndexChangedListBox6(object sender, System.EventArgs e)
        {
            labelSel.Text = "ListBox6" + DumpElements((ListBox)sender);
        }
    }

}