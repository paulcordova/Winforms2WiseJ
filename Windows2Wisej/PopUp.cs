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
    public partial class PopUp : Form
    {
        public PopUp()
        {
            InitializeComponent();
        }

        private void btnBell_Click(object sender, EventArgs e)
        {
            //new NotificationPopup().ShowPopup(btnBell);
        }
    }
}
