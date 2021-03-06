﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI.UsrCtrlManage
{
    public partial class EmployeeUsrCtrl : UserControl
    {
        public EmployeeUsrCtrl()
        {
            InitializeComponent();
        }

        private void txbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void picFood_MouseHover(object sender, EventArgs e)
        {
            this.lbAdding.Visible = true;
        }

        private void picFood_MouseLeave(object sender, EventArgs e)
        {
            this.lbAdding.Visible = false;
        }



        private void radioMale_Click(object sender, EventArgs e)
        {
            lbMale.Enabled = true;
            lbFemale.Enabled = false;
        }

     

        private void radioFemale_Click(object sender, EventArgs e)
        {

            lbMale.Enabled = false;
            lbFemale.Enabled = true;
        }
    }
}
