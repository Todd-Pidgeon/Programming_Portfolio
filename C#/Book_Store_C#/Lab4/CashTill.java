
package Lab4;

/**
Author : Todd Pidgeon
Date : 03/06/2017
Description : the class structure for CashTill.
**/

public class CashTill {
    private double runningTotal;
    
    CashTill(){
        runningTotal = 0;
    }
    
    public void sellItem(SaleableItem pPub){
        runningTotal = runningTotal + pPub.getPrice();
        pPub.sellCopy();
        System.out.println("\nSold\n" + pPub + " @ " + pPub.getPrice() 
                + "\nSubtotal = " + runningTotal);
    }
    
    public void showTotal(){
        System.out.println("Grand Total: " + runningTotal);
    }
}
