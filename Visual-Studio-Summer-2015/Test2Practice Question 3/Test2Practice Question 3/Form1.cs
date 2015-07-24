using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2Practice_Question_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                checkedListBox1.Items.Clear();
                //now create an array for files
                string[] files = Directory.GetFiles(FBD.SelectedPath);
                //now create an array for directories
                string[] dirs = Directory.GetDirectories(FBD.SelectedPath);

                //now just show the files/dirs in checkedListBox1
                //use a foreach loop

                foreach (string file in files)
                {
                    checkedListBox1.Items.Add(file);
                }

                //now do the same for dirs
                foreach (string dir in dirs)
                {
                    checkedListBox1.Items.Add(dir);
                }
            }
        }
    }
}