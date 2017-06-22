
package Lab4;

/**
Author : Todd Pidgeon
Date : 03/06/2017
Description : the class structure for publication.
**/

public class Publication implements SaleableItem{
    private String title;
    private double price;
    private int copies;
    
    public Publication(){
        
    }

    public Publication(String title, double price, int copies) {
        this.title = title;
        this.price = price;
        this.copies = copies;
    }
    
    @Override
    public void sellCopy() {
    }
    
    /**
     * @return the price
     */
    @Override
    public double getPrice() {
        return price;
    }
    
    /**
     * @return the title
     */
    public String getTitle() {
        return title;
    }

    /**
     * @param title the title to set
     */
    public void setTitle(String title) {
        this.title = title;
    }

    /**
     * @param price the price to set
     */
    public void setPrice(double price) {
        this.price = price;
    }

    /**
     * @return the copies
     */
    public int getCopies() {
        return copies;
    }

    /**
     * @param copies the copies to set
     */
    public void setCopies(int copies) {
        this.copies = copies;
    }
    
}
