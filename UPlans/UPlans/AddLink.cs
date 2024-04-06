﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPlans
{
    public partial class AddLink : Form
    {
        public string linkName { get; private set; }
        public string linkUrl { get; private set; }
        public Color linkColor { get; private set; }
        public AddLink()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtUrl.Text))
            {
                linkName = txtName.Text;
                linkUrl = txtUrl.Text;
                linkColor = lblColor.BackColor;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.ShowHelp = true;
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            lblColor.BackColor = dialog.Color;
            linkColor = dialog.Color;
        }
    }
}
