using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Configuration;
using Windows2Wisej.Views.Contacts;

namespace Windows2Wisej
{
    public partial class frmContacts : Form
    {
        public frmContacts()
        {
            InitializeComponent();

            ucContacts contacts = new ucContacts();
            contacts.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(contacts);
        }
    }
}
