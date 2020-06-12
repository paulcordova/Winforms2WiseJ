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
    public partial class ListViewVirtualModeTest : Form
    {
        ListView lv;
        ColumnHeader[] columns;
        ComboBox view_cb;
        Label view_label;
        Label warning_label;

        const int ItemsCount = 500;

        static readonly string[] Images = {
                "abiword_48.png",
                "bmp.png",
                "disks.png"
        };

        static readonly string ImagesPath = "";
        public ListViewVirtualModeTest()
        {
            InitializeComponent();

            lv = new ListView();
            lv.Location = new Point(10, 10);
            lv.Size = new Size(400, 500);
            //lv.FullRowSelect = true;
            lv.SmallImageList = new ImageList();
            //lv.SmallImageList.ColorDepth = ColorDepth.Depth32Bit;
            lv.SmallImageList.ImageSize = new Size(24, 24);
            lv.LargeImageList = new ImageList();
            //lv.LargeImageList.ColorDepth = ColorDepth.Depth32Bit;
            lv.LargeImageList.ImageSize = new Size(32, 32);
            lv.RetrieveVirtualItem += ListViewRetrieveItem;
            lv.VirtualListSize = ItemsCount;
            lv.VirtualMode = true;

            LoadListViewImages();

            view_label = new Label();
            view_label.Location = new Point(lv.Right + 10, 10);
            view_label.Text = "View";
            view_label.AutoSize = true;

            warning_label = new Label();
            warning_label.Location = new Point(10, lv.Bottom + 5);
            warning_label.Font = new Font(Font, FontStyle.Bold);
            warning_label.ForeColor = Color.Red;
            warning_label.AutoSize = true;

            view_cb = new ComboBox();
            view_cb.Location = new Point(lv.Right + 70, 10);
            view_cb.Items.AddRange(new object[] { View.LargeIcon, View.SmallIcon, View.Tile, View.Details, View.List });

            view_cb.SelectedItem = lv.View;
            view_cb.SelectedIndexChanged += ViewCBSelectedIndexChanged;

            Controls.AddRange(new Control[] { lv, view_label, warning_label, view_cb });

            Size = new Size(630, 580);
            Text = "VirtualMode tester";
        }


        void UpdateView(View view)
        {
            if (view == View.Details)
            {
                if (columns == null)
                    columns = new ColumnHeader[] {
                    new ColumnHeader () {Text= "Main column" },
                    new ColumnHeader () {Text= "Sub column #1" },
                    new ColumnHeader () {Text= "Sub column #2" }
                };

                lv.Columns.AddRange(columns);
                lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                lv.Columns.Clear();
            }

            // Tile view is don't supported in VirtualMode
            if (view != View.Tile)
            {
                lv.View = view;
            }
           
        }

        void ListViewRetrieveItem(object o, RetrieveVirtualItemEventArgs args)
        {
            if (args.ItemIndex == ItemsCount - 1 && !IsHandleCreated)
                warning_label.Text = "Warning: The very last item was requested, which should not happen in load time (not visible yet)";

            // for testing purposes, we are creating one item per
            // invocation
            ListViewItem item = new ListViewItem("Item #" + args.ItemIndex);
            item.SubItems.Add("Sub item " + args.ItemIndex + "-1");
            item.SubItems.Add("Sub item " + args.ItemIndex + "-2");
            if (lv.View == View.Details && args.ItemIndex % 2 == 0)
                item.BackColor = Color.WhiteSmoke;

            item.ImageIndex = args.ItemIndex % Images.Length;
            args.Item = item;
        }

        void ViewCBSelectedIndexChanged(object o, EventArgs args)
        {
            UpdateView((View)view_cb.SelectedItem);
        }

        void LoadListViewImages()
        {
            //Image img = global::Wisej.Web.UITests.Properties.Resources.abiword_48;
            Image img = global::Windows2Wisej.Properties.Resources.abiword_48;
            lv.SmallImageList.Images.Add(img);
            lv.LargeImageList.Images.Add(img);
            img = global::Windows2Wisej.Properties.Resources.bmp;
            lv.SmallImageList.Images.Add(img);
            lv.LargeImageList.Images.Add(img);
            img = global::Windows2Wisej.Properties.Resources.disks;
            lv.SmallImageList.Images.Add(img);
            lv.LargeImageList.Images.Add(img);
            img = global::Windows2Wisej.Properties.Resources.evolution;
            lv.SmallImageList.Images.Add(img);
            lv.LargeImageList.Images.Add(img);
        }
    }
}
