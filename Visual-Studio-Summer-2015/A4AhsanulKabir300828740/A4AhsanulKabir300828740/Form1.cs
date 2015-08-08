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
            List<Book> FullList = new List<Book>();
            List<Book> SortedList = new List<Book>();
            List<Book> SelectedList = new List<Book>();
            //List<Book> SelectedList = new List<Book>();
            //Book[] SelectedList
            Book ading = new Book("Java for beginners", "Mary Jane", 30, 2014);
            FullList.Add(ading);

            ading = new Book("Java Enterprise", "Mary Jane", 33, 2015);
            FullList.Add(ading);
            ading = new Book("Practical C#", "John Smith", 20, 2015);
            FullList.Add(ading);
            ading = new Book("Javascript", "John Smith", 30.99, 2014);
            FullList.Add(ading);
            ading = new Book("Fundamentals of C++", "Mark Abel", 55, 2015);
            FullList.Add(ading);
            ading = new Book("Java by example", "Jim Young", 100, 2014);
            FullList.Add(ading);
            try
            {
                lbxReport.Items.Clear();
                if (String.IsNullOrEmpty(txtAuthor.Text) && String.IsNullOrEmpty(txtTitle.Text))    //txtAuthor.Text != null && txtTitle.Text != null)
                {
                    var SelectList = from b in FullList
                                     select b;
                    foreach (Book x in SelectList)
                    {
                        SelectedList.Add(x);
                    }
                    //MessageBox.Show("1");
                }
                else if (String.IsNullOrEmpty(txtAuthor.Text))
                {
                    var SelectList = from b in FullList
                                     where b.Title == txtTitle.Text
                                     select b;
                    foreach (Book x in SelectList)
                    {
                        SelectedList.Add(x);
                    }
                    // MessageBox.Show("3");
                }
                else if (String.IsNullOrEmpty(txtTitle.Text))
                {
                    var SelectList = from b in FullList
                                     where b.Author == txtAuthor.Text
                                     select b;
                    foreach (Book x in SelectList)
                    {
                        SelectedList.Add(x);
                    }
                    //MessageBox.Show("2");
                }
                else
                {
                    var SelectList = from b in FullList
                                     where b.Title == txtTitle.Text
                                     where b.Author == txtAuthor.Text
                                     select b;
                    foreach (Book x in SelectList)
                    {
                        SelectedList.Add(x);
                    }
                    //MessageBox.Show("3");
                }
                if (rbPrice.Checked)
                {
                    var SortList = from c in SelectedList
                                   orderby c.Price
                                   select c;
                    foreach (Book x in SortList)
                    {
                        SortedList.Add(x);
                    }
                }
                else if (rbYear.Checked)
                {
                    var SortList = from c in SelectedList
                                   orderby c.Year
                                   select c;
                    foreach (Book x in SortList)
                    {
                        SortedList.Add(x);
                    }
                }
                else
                {
                    var SortList = from c in SelectedList
                                   select c;
                    foreach (Book x in SortList)
                    {
                        SortedList.Add(x);
                    }
                }
                foreach (Book a in SortedList)
                {
                    lbxReport.Items.Add(a);
                }

                /* foreach (Book a in lbxReport.Items)
                {
                    lbxReport.Item.Remove;
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}