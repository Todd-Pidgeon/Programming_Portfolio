
package Lab4;

/**
Author : Todd Pidgeon
Date : 03/06/2017
Description : the class structure for Ticket.
**/

public class Ticket implements SaleableItem {

    @Override
    public void sellCopy() {
        System.out.println("***TICKET VOUCHER***");
        //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public double getPrice() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}
