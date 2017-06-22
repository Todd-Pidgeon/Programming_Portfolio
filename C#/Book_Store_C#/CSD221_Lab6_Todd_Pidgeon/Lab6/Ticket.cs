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
    Description : the class structure for Ticket.
    **/

    public class Ticket : SaleableItem
    {
        private String description;
        private Double price;
        private String client;

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public double getPrice()
        {
            return Price;
        }

        public void sellCopy()
        {
            throw new NotImplementedException();
        }
    }
}
