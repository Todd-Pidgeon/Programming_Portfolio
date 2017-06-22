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
    Description : the class structure for magazine.
    **/

    public class Magazine : Publication
    {
    private int orderQty;
    private DateTime currIssue;

    public Magazine()
    {
    }

    public Magazine(int orderQty, DateTime currIssue)
    {
        this.orderQty = orderQty;
        this.currIssue = currIssue;
    }

        public Magazine(String title, double price, int copies, DateTime currIssue)
                :base(title, price, copies)
        {
            this.orderQty = orderQty;
            this.currIssue = currIssue;
        }
    /**
     * @return the orderQty
     */
    public int getOrderQty()
    {
        return orderQty;
    }

    /**
     * @param orderQty the orderQty to set
     */
    public void setOrderQty(int orderQty)
    {
        this.orderQty = orderQty;
    }

    /**
     * @return the currIssue
     */
    public DateTime getCurrIssue()
    {
        return currIssue;
    }

    /**
     * @param currIssue the currIssue to set
     */
    public void setCurrIssue(DateTime currIssue)
    {
        this.currIssue = currIssue;
    }

    void setCurrIssue(String strDate)
    {
        //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    // A ToString override

    public override string ToString()
    {
        return "Title : " + getTitle() + "\n"
            + "Price : " + getPrice() + "\n"
            + "Copies : " + getCopies() + "\n"
            + "Current Issue : " + getCurrIssue() + "\n";
    }
}
}
