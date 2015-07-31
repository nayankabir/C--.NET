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
        }

        private void radiobtn_Remove_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button_Process_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbox_LogItem.Text))
            {
                MessageBox.Show(@"Hey you gotta enter something");
                radiobtn_Add.Checked = false;
                radiobtn_Remove.Checked = false;
            }
            if (!radiobtn_Add.Checked && !radiobtn_Remove.Checked && !string.IsNullOrEmpty(textbox_LogItem.Text))
            {
                MessageBox.Show("Please select either Add or Remove. Try again.");
                textbox_LogItem.Text = null;
                radiobtn_Remove.Checked = false;
            }
            else if (textbox_LogItem.Text != null)
            {
                //enter calculations
                if (radiobtn_Add.Checked)
                {
                    listbox_LogContent.Items.Add(textbox_LogItem.Text);
                    textbox_LogItem.Text = null;
                    radiobtn_Add.Checked = false;
                }
                if (radiobtn_Remove.Checked)
                {
                    if (!listbox_LogContent.Items.Contains(textbox_LogItem.Text))
                    {
                        MessageBox.Show("This doesn't exist in the Log Items. Try again.");
                        textbox_LogItem.Text = null;
                        radiobtn_Remove.Checked = false;
                    }

                    listbox_LogContent.Items.Remove(textbox_LogItem.Text);
                    textbox_LogItem.Text = null;
                    radiobtn_Remove.Checked = false;
                }
            }
        }

        private void textbox_LogItem_TextChanged(object sender, EventArgs e)
        {
        }

        private void radiobtn_Add_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}