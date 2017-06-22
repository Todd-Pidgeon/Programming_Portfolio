using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    /**
    Author : Todd Pidgeon
    Date : 03/06/2017
    Description : the class structure for book.
    **/
    class Book : Publication
    {
        private String author;

        public String Author
        {
            get { return author; }
            set { author = value; }
        }

        public Book(String title, int copies, double price, String author)
            :base(title, copies, price)
        {
            this.author = author;
        }

        override public void sellCopy()
        {

        }
        override public Double getPrice()
        {
            return Price;
        }

        public override string ToString()
        {
            return "I'm a book";
        }
    }
}
