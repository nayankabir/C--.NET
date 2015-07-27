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
            while (textbox_LogItem.Text != null)
            {
                //enter calculation
                if (radiobtn_Add.Checked == true)
                {
                    listbox_LogContent.Items.Add(textbox_LogItem.ToString());
                    textbox_LogItem.Text = null;
                    radiobtn_Add.Checked = false;
                    break;
                }
                else if (radiobtn_Remove.Checked == true)
                {
                    listbox_LogContent.Items.Remove(textbox_LogItem.ToString());
                    textbox_LogItem.Text = null;
                    radiobtn_Remove.Checked = false;
                    break;
                }
            }
            while (textbox_LogItem.Text == null)
            {
                MessageBox.Show(@"Hey man you gotta enter something");
                break;
            }
        }

        private void textbox_LogItem_TextChanged(object sender, EventArgs e)
        {
        }
    }
}