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
    Description : the class structure for CashTill.
     **/

    class CashTill
    {
        private Double runningTotal;
        public void sellItem(SaleableItem p)
        {
            runningTotal += p.getPrice();
            p.sellCopy();
        }
        public CashTill()
        {
            runningTotal = 0;
        }
    }
}
