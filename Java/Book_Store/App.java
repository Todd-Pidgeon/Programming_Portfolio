
package Lab4;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Scanner;

/**
Author : Todd Pidgeon
Date : 03/06/2017
Description : A publication store with CRUD, enter different publications, 
* edit and delete them.
**/



public class App {
    // Declare variables.
    private static List<Book> books = new ArrayList<Book>();
    private static List<Magazine> magazines = new ArrayList<Magazine>();
    private static List<Magazine> discMags = new ArrayList<Magazine>();
    
    private static int activeBook = 0;
    private static int activeMagazine = 0;
    private static int activeDiscMag = 0;
    
    private static boolean boolBook = false;
    private static boolean boolMagazine = false;
    private static boolean boolDiscMag = false;
    
    DateFormat format = new SimpleDateFormat("MMMM d, yyyy");
    
    public void run() throws ParseException{
        
        boolean exitMenu = false;
        boolean exitBookMenu = false;
        boolean exitMagMenu = false;
        boolean exitDiscMenu = false;
        boolean exitTicketMenu = false;
        
        Scanner input = new Scanner(System.in);
        
        // Main menu loop
        while(!exitMenu){
            
            theLine();
            // Main Menu
            System.out.println("\nChoose a Publication Type\n\n" 
                    + "1. Book\n"
                    + "2. Magazine\n"
                    + "3. Disc Magazine\n"
                    + "4. Ticket\n\n"
                    + "Enter Selection: ");
            
            int menuSelection = input.nextInt();
            
            switch(menuSelection) {
                case 1: 
                    // Book menu
                    while(!exitBookMenu){
                        System.out.println("\nBooks\n\n" 
                        + "1. Add a Book\n"
                        + "2. Edit a Book\n"
                        + "3. Delete a Book\n"
                        + "4. Sell a Book\n\n"
                        + "Enter Selection: ");

                        int menuBookSelection = input.nextInt();

                        switch(menuBookSelection) {
                            case 1:
                                boolBook = true;
                                addAPublication();
                                break;
                            case 2:
                                editABook();
                                break;
                            case 3: 
                                deleteABook();
                                break;
                            case 4: 
                                sellABook();
                                break;
                            case -1:
                                exitBookMenu = true;
                                break;
                            default:
                                System.out.println("Please enter a valid choice.");
                                break;
                        }
                    }
                    break;
                case 2:
                    // Magazine Menu
                    while(!exitMagMenu){
                        System.out.println("\nMagazines\n\n" 
                        + "1. Add a Magazine\n"
                        + "2. Edit a Magazine\n"
                        + "3. Delete a Magazine\n"
                        + "4. Sell a Magazine\n\n"
                        + "Enter Selection: ");

                        int menuMagazineSelection = input.nextInt();

                        switch(menuMagazineSelection) {
                            case 1: 
                                boolMagazine = true;
                                addAPublication();
                                break;
                            case 2:
                                editAMag();
                                break;
                            case 3: 
                                deleteAMag();
                                break;
                            case 4: 
                                sellAMag();
                                break;
                            case -1:
                                exitMagMenu = true;
                                break;
                            default:
                                System.out.println("Please enter a valid choice.");
                                break;
                        }
                    }
                    break;
                case 3:
                    // Disc Mag menu
                    while(!exitDiscMenu){
                        System.out.println("\nDisc Magazines\n\n" 
                        + "1. Add a Disc Magazine\n"
                        + "2. Edit a Disc Magazine\n"
                        + "3. Delete a Disc Magazine\n"
                        + "4. Sell a Disc Magazine\n\n"
                        + "Enter Selection: ");

                        int menuDiscMagazineSelection = input.nextInt();

                        switch(menuDiscMagazineSelection) {
                            case 1: 
                                boolDiscMag = true;
                                addAPublication();
                                break;
                            case 2:
                                editADisc();
                                break;
                            case 3: 
                                deleteADiscMag();
                                break;
                            case 4: 
                                sellADiscMag();
                                break;
                            case -1:
                                exitDiscMenu = true;
                                break;
                            default:
                                System.out.println("Please enter a valid choice.");
                                break;
                        }
                    }
                case 4:
                    // Disc Mag menu
                    while(!exitTicketMenu){
                        System.out.println("\nTickets\n\n" 
                        + "1. Sell a Ticket\n"
                        + "Enter Selection: ");

                        int menuDiscMagazineSelection = input.nextInt();

                        switch(menuDiscMagazineSelection) {
                            case 1: 
                                Ticket ticket = new Ticket();
                                ticket.sellCopy();
                                break;
                            case -1:
                                exitTicketMenu = true;
                                break;
                            default:
                                System.out.println("Please enter a valid choice.");
                                break;
                        }
                    }  
                    break;
                case -1:
                    exitMenu = true;
                    break;
                default:
                    System.out.println("Please enter a valid choice.");
                    break;
                }
        }
        System.exit(0);
    }
    
    public void theLine() {
        System.out.println("--------------------------------------------------");
    }
    
    // Funtion to add publications to the lists.
    public void addAPublication() throws ParseException {
        if (boolBook = true){
            Scanner inputBook = new Scanner(System.in);

            theLine();

            System.out.println("\nAdd A Book\n\n   Enter Author:");
            String author = inputBook.next();

            System.out.println("\n  Quantity to Order:");
            int copies = inputBook.nextInt();

            System.out.println("\n  Enter Title:");
            String title = inputBook.next();

            System.out.println("\n  Enter Price:");
            double price = inputBook.nextDouble();

            Book book = new Book(author, copies, title, price);

            books.add(book);
            activeBook++;
        }
        else if (boolMagazine = true){
            Scanner inputMag = new Scanner(System.in);

            theLine();

            System.out.println("\nAdd A Magazine\n\n   Enter Title:");
            String title = inputMag.next();

            System.out.println("\n  Enter Price:");
            double price = inputMag.nextDouble();

            System.out.println("\n  Quantity to Order:");
            int copies = inputMag.nextInt();

            System.out.println("\n  Enter the Date of the Issue:");
            String strDate = inputMag.next();
            Date currIssue = format.parse(strDate);

            Magazine magazine = new Magazine(title, price, copies, currIssue);

            magazines.add(magazine);
            activeMagazine++;
        }
        else if (boolDiscMag = true){
            Scanner inputDicsMag = new Scanner(System.in);

            theLine();

            System.out.println("\nAdd A Disc Magazine\n\n   Enter Title:");
            String title = inputDicsMag.next();

            System.out.println("\n  Enter Price:");
            double price = inputDicsMag.nextDouble();

            System.out.println("\n  Quantity to Order:");
            int copies = inputDicsMag.nextInt();

            System.out.println("\n  Enter the Date of the Issue:");
            String strDate = inputDicsMag.next();
            Date currIssue = format.parse(strDate);

            Magazine discMag = new Magazine(title, price, copies, currIssue);

            discMags.add(discMag);
            activeDiscMag++;
        }            
    }
    
    
    // Funtion to print all the books.
    public void listAllBooks() {
        int bookNumber = 0;
        
        if (books.isEmpty()){
            System.out.println("Sorry there are no books.");
        }
        else{
            theLine();
        
            System.out.println("\nAll Books\n");
        
            for(Lab4.Book book:books){
                if(book==null)
                    continue;
            
                System.out.println("Book #: " + bookNumber);
                System.out.println(book);
            
                bookNumber++;
            }
        }
    }
    
        // Funtion to print all the magazines.
    public void listAllMags() {
        int magNumber = 0;
        
        if (magazines.isEmpty()){
            System.out.println("Sorry there are no Magazines.");
        }
        else{
            theLine();
        
            System.out.println("\nAll Magazines\n");
        
            for(Lab4.Magazine magazine:magazines){
                if(magazine==null)
                    continue;
            
                System.out.println("Magazine #: " + magNumber);
                System.out.println(magazine);
            
                magNumber++;
            }
        }
    }
    
            // Funtion to print all the disc magazines.
    public void listAllDiscMags() {
        int discNumber = 0;
        
        if (discMags.isEmpty()){
            System.out.println("Sorry there are no Disc Magazines.");
        }
        else{
            theLine();
        
            System.out.println("\nAll Disc Magazines\n");
        
            for(Lab4.Magazine discMag:discMags){
                if(discMag==null)
                    continue;
            
                System.out.println("Disc Mag #: " + discNumber);
                System.out.println(discMag);
            
                discNumber++;
            }
        }
    }
    
    // Funtion to delete a book.
    public void deleteABook() {
        listAllBooks();
        
        theLine();
        
        if (books.isEmpty()){
            System.out.println("Sorry there are no books.");
        }
        else{
            Scanner input = new Scanner(System.in);
            System.out.println("\nDelete a book\n\n  Enter book number:");
            int bookToDelete = input.nextInt();

            books.remove(bookToDelete);

        }
    }
    
    // Funtion to delete a magazine.
    public void deleteAMag() {
        listAllMags();
        
        theLine();
        
        if (magazines.isEmpty()){
            System.out.println("Sorry there are no magazines.");
        }
        else{
            Scanner input = new Scanner(System.in);
            System.out.println("\nDelete a Magazine\n\n  Enter Magazine number:");
            int magToDelete = input.nextInt();

            magazines.remove(magToDelete);

        }
    }
    
        // Funtion to delete a car from the lot.
    public void deleteADiscMag() {
        listAllDiscMags();
        
        theLine();
        
        if (discMags.isEmpty()){
            System.out.println("Sorry there are no Disc Magazines.");
        }
        else{
            Scanner input = new Scanner(System.in);
            System.out.println("\nDelete a Disc Magazine\n\n  Enter Disc Mag number:");
            int discToDelete = input.nextInt();

            discMags.remove(discToDelete);
        }
    }
    
    // Funtion to edit the propeties of any car in the lot.
    public void editABook() {
        listAllBooks();
        
        theLine();
        
        if (books.isEmpty()){
            System.out.println("Sorry there are no Books.");
        }
        else{
            Scanner input = new Scanner(System.in);
            System.out.println("\nEdit A Book\n\n  Enter book number:");
            int bookToEdit = input.nextInt();

            System.out.println("\n  Enter Author:");
            String author = input.next();

            System.out.println("\n  Enter copies ordered:");
            int copies = input.nextInt();

            System.out.println("\n  Enter Title:");
            String title = input.next();
            
            System.out.println("\n  Enter price:");
            int price = input.nextInt();

            books.get(bookToEdit).setAuthor(author);
            books.get(bookToEdit).setCopies(copies);
            books.get(bookToEdit).setTitle(title);
            books.get(bookToEdit).setPrice(price);
        }
    }
    
        // Funtion to edit the propeties of any car in the lot.
    public void editAMag() throws ParseException {
        listAllMags();
        
        theLine();
        
        if (magazines.isEmpty()){
            System.out.println("Sorry there are no magazines.");
        }
        else{
            Scanner input = new Scanner(System.in);
            System.out.println("\nEdit A Magazine\n\n  Enter Magazine number:");
            int magToEdit = input.nextInt();

            System.out.println("\n  Enter title:");
            String title = input.next();

            System.out.println("\n  Enter price:");
            double price = input.nextDouble();

            System.out.println("\n  Enter the number of copies:");
            int copies = input.nextInt();
            
            System.out.println("\n  Enter the Date of the Issue:");
            String strDate = input.next();
            Date currIssue = format.parse(strDate);

            magazines.get(magToEdit).setTitle(title);
            magazines.get(magToEdit).setPrice(price);
            magazines.get(magToEdit).setCopies(copies);
            magazines.get(magToEdit).setCurrIssue(currIssue);
        }
    }
    
        // Funtion to edit the propeties of any car in the lot.
    public void editADisc() throws ParseException {
        listAllDiscMags();
        
        theLine();
        
        if (discMags.isEmpty()){
            System.out.println("Sorry there are no Disc Magazines.");
        }
        else{
            Scanner input = new Scanner(System.in);
            System.out.println("\nEdit A Disc Magazine\n\n  Enter Disc Magazine number:");
            int magToEdit = input.nextInt();

            System.out.println("\n  Enter title:");
            String title = input.next();

            System.out.println("\n  Enter price:");
            double price = input.nextDouble();

            System.out.println("\n  Enter the number of copies:");
            int copies = input.nextInt();
            
            System.out.println("\n  Enter the Date of the Issue:");
            String strDate = input.next();
            Date currIssue = format.parse(strDate);

            discMags.get(magToEdit).setTitle(title);
            discMags.get(magToEdit).setPrice(price);
            discMags.get(magToEdit).setCopies(copies);
            discMags.get(magToEdit).setCurrIssue(currIssue);
        }
    }
    
    public void sellABook() {
        listAllBooks();
        
        theLine();
        
        if (books.isEmpty()){
            System.out.println("Sorry there are no Books.");
        }
        else{
            Scanner input = new Scanner(System.in);
            System.out.println("\nSell A Book\n\n  Enter Book number:");
            int bookToSell = input.nextInt();
            
            int numCopies = books.get(bookToSell).getCopies() - 1;
            
            books.get(bookToSell).setCopies(numCopies);
            
            CashTill sell = new CashTill();
            
            sell.sellItem(books.get(bookToSell));
           
            sell.showTotal();
        }
    }
    
    public void sellAMag() {
        listAllMags();
        
        theLine();
        
        if (magazines.isEmpty()){
            System.out.println("Sorry there are no Magazines.");
        }
        else{
            Scanner input = new Scanner(System.in);
            System.out.println("\nSell A Magazine\n\n  Enter Magazine number:");
            int magToSell = input.nextInt();
            
            int numCopies = magazines.get(magToSell).getCopies() - 1;
            
            magazines.get(magToSell).setCopies(numCopies);
            
            CashTill sell = new CashTill();
            
            sell.sellItem(books.get(magToSell));
           
            sell.showTotal();
        }
    }
        
     public void sellADiscMag() {
        listAllDiscMags();
        
        theLine();
        
        if (discMags.isEmpty()){
            System.out.println("Sorry there are no Disc Magazines.");
        }
        else{
            Scanner input = new Scanner(System.in);
            System.out.println("\nSell A Disc Magazine\n\n  Enter Disc Magazine number:");
            int discMagToSell = input.nextInt();
            
            int numCopies = discMags.get(discMagToSell).getCopies() - 1;
            
            discMags.get(discMagToSell).setCopies(numCopies);
            
            CashTill sell = new CashTill();
            
            sell.sellItem(books.get(discMagToSell));
           
            sell.showTotal();
        }
    }
}
