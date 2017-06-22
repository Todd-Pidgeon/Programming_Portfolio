using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    /*
    Author : Todd Pidgeon
    Date : 03/06/2017
    Description : the class structure for SaleableItem Interface.
 */


    public interface SaleableItem
    {
        void sellCopy();
        double getPrice();
    }
}
