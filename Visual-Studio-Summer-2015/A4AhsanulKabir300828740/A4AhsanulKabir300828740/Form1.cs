using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            //"var" is actually preferred when dealing with LINQ because you don't know what type of data type LINQ might return

            //user leaves both textboxes empty, ALL items must be selected

            if (string.IsNullOrEmpty(txtAuthor.Text))
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Assignment4;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select * From Table_1", con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    lbxReport.Items.Add(row.ToString());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignment4DataSetFinal.Table_1' table. You can move, or remove it, as needed.
            this.table_1TableAdapter1.Fill(this.assignment4DataSetFinal.Table_1);
            // TODO: This line of code loads data into the 'assignment4DataSet.Table_1' table. You can move, or remove it, as needed.
            this.table_1TableAdapter.Fill(this.assignment4DataSet.Table_1);
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbxReport_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}