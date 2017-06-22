
package Lab4;

/**
Author : Todd Pidgeon
Date : 03/06/2017
Description : the class structure for discMag.
**/

public class DiscMag extends Magazine{
   
    public DiscMag(){
        
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
