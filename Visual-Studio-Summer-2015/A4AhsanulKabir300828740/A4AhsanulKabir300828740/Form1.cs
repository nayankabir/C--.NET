using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A4AhsanulKabir300828740
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //write code that generates a book report
            //
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignment4DataSet.Table_1' table. You can move, or remove it, as needed.
            this.table_1TableAdapter.Fill(this.assignment4DataSet.Table_1);

        }
    }
}