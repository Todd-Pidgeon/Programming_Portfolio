using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
Author : Todd Pidgeon
Date : 03/06/2017
Description : the class structure for publication.
**/

namespace Lab6
{
    public abstract class Publication : SaleableItem
    {
        private String title;
        private Double price;
        private int copies;
        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        public Double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Copies
        {
            get { return copies; }
            set { copies = value; }
        }

        public Publication(String title, int copies, double price)
        {
            this.title = title;
            this.price = price;
            this.copies = copies;
        }

        public abstract void sellCopy();
        public abstract double getPrice();
    }
}
