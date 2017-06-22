
package Lab4;

import java.util.Date;

/**
Author : Todd Pidgeon
Date : 03/06/2017
Description : the class structure for magazine.
**/

public class Magazine extends Publication{
    private int orderQty;
    private Date currIssue;

    public Magazine() {
    }

    public Magazine(int orderQty, Date currIssue) {
        this.orderQty = orderQty;
        this.currIssue = currIssue;
    }

    public Magazine(String title, double price, int copies, Date currIssue) {
        super(title, price, copies);
        this.orderQty = orderQty;
        this.currIssue = currIssue;
    }
    /**
     * @return the orderQty
     */
    public int getOrderQty() {
        return orderQty;
    }

    /**
     * @param orderQty the orderQty to set
     */
    public void setOrderQty(int orderQty) {
        this.orderQty = orderQty;
    }

    /**
     * @return the currIssue
     */
    public Date getCurrIssue() {
        return currIssue;
    }

    /**
     * @param currIssue the currIssue to set
     */
    public void setCurrIssue(Date currIssue) {
        this.currIssue = currIssue;
    }

    void setCurrIssue(String strDate) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
    // A ToString override
    @Override
    public String toString() {
        return "Title : " + getTitle() + "\n"
            + "Price : " + getPrice() + "\n"
            + "Copies : " + getCopies() + "\n"
            + "Current Issue : " + getCurrIssue() + "\n";
    }
}
