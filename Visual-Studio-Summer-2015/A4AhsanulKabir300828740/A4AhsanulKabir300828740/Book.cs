using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4AhsanulKabir300828740
{
    internal class Book
    {
        private string title, author;
        private double price;
        private int year;

        public Book(string title, string author, double price, int year)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.year = year;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} \t{1} \t{2:C} \t{3}", title, author, price, year);
        }
    }
}