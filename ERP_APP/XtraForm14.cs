﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_APP
{
    public partial class workCenterForm : DevExpress.XtraEditors.XtraForm
    {
        public workCenterForm()
        {
            InitializeComponent();
        }

        private void workCenterForm_Load(object sender, EventArgs e)
        {

        }

        private void homePageButton_Click(object sender, EventArgs e)
        {
            mainForm xtraForm = new mainForm();

            xtraForm.Show();
            this.Hide();
        }
    }
}