using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3AhsanulKabir300828740
{
    public partial class Form1 : Form
    {
        public int WhatUserSelected;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void radiobtn_Add_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtn_Add.Checked == true)
            {
                WhatUserSelected = 1; //or am i supposed to put the actual calculation here?
            }
        }

        private void radiobtn_Remove_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtn_Remove.Checked == true)
            {
                WhatUserSelected = 2;
            }
        }

        private void button_Process_Click(object sender, EventArgs e)
        {
            if (this.textbox_LogItem.Text != null)
            {
                //enter calculation
                if (VScroll)
                {
                }
                else if (VScroll)
                {
                }

                MessageBox.Show(result);
            }
            else if (this.textbox_LogItem.Text == null)
            {
                MessageBox.Show(@"Hey man you gotta enter something");
            }
        }

        private void textbox_LogItem_TextChanged(object sender, EventArgs e)
        {
        }
    }
}