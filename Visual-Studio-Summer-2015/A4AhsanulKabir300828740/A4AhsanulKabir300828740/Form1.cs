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
            List<Book> SortedList = new List<Book>();
            List<Book> SelectedList = new List<Book>();
            List<Book> FullList = new List<Book>();

            Book BookList = new Book("Java for beginners\t\t", "Mary Jane\t", 30, 2014);
            FullList.Add(BookList);
            BookList = new Book("Java Enterprise\t\t", "Mary Jane\t", 33, 2015);
            FullList.Add(BookList);
            BookList = new Book("Practical C#\t\t", "John Smith\t", 20, 2015);
            FullList.Add(BookList);
            BookList = new Book("Javascript\t\t", "John Smith\t", 30.99, 2014);
            FullList.Add(BookList);
            BookList = new Book("Fundamentals of C++\t", "Mark Abel\t", 55, 2015);
            FullList.Add(BookList);
            BookList = new Book("Java by example\t\t", "Jim Young\t", 100, 2014);
            FullList.Add(BookList);
            try
            {
                lbxReport.Items.Clear();
                if (String.IsNullOrEmpty(txtAuthor.Text) && String.IsNullOrEmpty(txtTitle.Text))
                {
                    var SelectList = from b in FullList
                                     select b;
                    foreach (Book x in SelectList)
                    {
                        SelectedList.Add(x);
                    }
                }
                else if (String.IsNullOrEmpty(txtAuthor.Text))
                {
                    var SelectList = from b in FullList
                                     where b.Title.Contains(txtTitle.Text)
                                     select b;
                    foreach (Book x in SelectList)
                    {
                        SelectedList.Add(x);
                    }
                }
                else if (String.IsNullOrEmpty(txtTitle.Text))
                {
                    var SelectList = from b in FullList
                                     where b.Author.Contains(txtAuthor.Text)
                                     select b;
                    foreach (Book x in SelectList)
                    {
                        SelectedList.Add(x);
                    }
                }
                else
                {
                    var SelectList = from b in FullList
                                     where b.Title.Contains(txtTitle.Text)
                                     where b.Author.Contains(txtAuthor.Text)
                                     select b;
                    foreach (Book x in SelectList)
                    {
                        SelectedList.Add(x);
                    }
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
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }
    }
}