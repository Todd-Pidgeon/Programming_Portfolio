
package Lab4;

/**
Author : Todd Pidgeon
Date : 03/06/2017
Description : the class structure for Ticket.
**/

public class Ticket implements SaleableItem {
    private double ticketcost = 1.00;
    
    @Override
    public void sellCopy() {
        System.out.println("***TICKET VOUCHER***");
        //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public double getPrice() {
        return ticketcost;
        //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
    @Override
    public String toString() {
        return "Ticket";
    }
}
