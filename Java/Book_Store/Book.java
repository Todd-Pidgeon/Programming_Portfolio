
package Lab4;

/**
Author : Todd Pidgeon
Date : 03/06/2017
Description : the class structure for book.
**/
public class Book extends Publication {
    private String author;

    public Book(){
        
    }

    public Book(String author) {
        this.author = author;
    }

    public Book(String author, int copies, String title, double price) {
        super(title, price, copies);
        this.author = author;
    }

    public void orderCopies(int numCopies){
        
    }

    /**
     * @return the author
     */
    public String getAuthor() {
        return author;
    }

    /**
     * @param author the author to set
     */
    public void setAuthor(String author) {
        this.author = author;
    }
    
    // A ToString override
    @Override
    public String toString() {
        return "Author : " + getAuthor() + "\n"
            + "Copies : " + getCopies() + "\n"
            + "Title : " + getTitle() + "\n"
            + "Price : " + getPrice() + "\n";
    }
    
    @Override
    public void sellCopy() {
        
    }
}
