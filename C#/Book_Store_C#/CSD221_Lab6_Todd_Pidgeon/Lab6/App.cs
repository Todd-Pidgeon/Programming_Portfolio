using System;
using System.Collections.Generic;

/**
Author : Todd Pidgeon
Date : 03/06/2017
Description : A publication store with CRUD, enter different publications, 
* edit and delete them.
**/


namespace Lab6
{
public class App
{
    // Declare variables.
    private static List<Book> books = new List<Book>();
    private static List<Magazine> magazines = new List<Magazine>();
    private static List<Magazine> discMags = new List<Magazine>();

    private static int activeBook = 0;
    private static int activeMagazine = 0;
    private static int activeDiscMag = 0;

    private static bool boolBook = false;
    private static bool boolMagazine = false;
    private static bool boolDiscMag = false;

    CashTill sell = new CashTill();

    //DateFormat format = new SimpleDateFormat("MMMM d, yyyy");

    public void run()
    {

        bool exitMenu = false;
        bool exitBookMenu = false;
        bool exitMagMenu = false;
        bool exitDiscMenu = false;
        bool exitTicketMenu = false;

        //Scanner input = new Scanner(System.in);
        
        // Main menu loop
        while(!exitMenu){
        exitMenu = false;
        exitBookMenu = false;
        exitMagMenu = false;
        exitDiscMenu = false;
        exitTicketMenu = false;
            theLine();
    // Main Menu
    Console.WriteLine("\nChoose a Publication Type\n\n" 
                    + "1. Book\n"
                    + "2. Magazine\n"
                    + "3. Disc Magazine\n"
                    + "4. Ticket\n\n"
                    + "Enter Selection: ");

                int menuSelection = 0;
                menuSelection = Convert.ToInt32(Console.ReadLine());

            switch (menuSelection) {
                case 1: 
                    // Book menu
                    while(!exitBookMenu){
                        Console.WriteLine("\nBooks\n\n" 
                        + "1. Add a Book\n"
                        + "2. Edit a Book\n"
                        + "3. Delete a Book\n"
                        + "4. Sell a Book\n\n"
                        + "Enter Selection: ");

                            int menuBookSelection = 0;
                            menuBookSelection = Convert.ToInt32(Console.ReadLine());

                            switch (menuBookSelection) {
                            case 1:
                                boolBook = true;
                                AddAPublication();
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
                                Console.WriteLine("Please enter a valid choice.");
                                break;
                        }
                    }
                    break;
                case 2:
                    // Magazine Menu
                    while(!exitMagMenu){
                        Console.WriteLine("\nMagazines\n\n" 
                        + "1. Add a Magazine\n"
                        + "2. Edit a Magazine\n"
                        + "3. Delete a Magazine\n"
                        + "4. Sell a Magazine\n\n"
                        + "Enter Selection: ");

                            int menuMagazineSelection = 0;
                            menuMagazineSelection = Convert.ToInt32(Console.ReadLine());

                            switch (menuMagazineSelection) {
                            case 1: 
                                boolMagazine = true;
                                AddAPublication();
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
                                Console.WriteLine("Please enter a valid choice.");
                                break;
                        }
                    }
                    break;
                case 3:
                    // Disc Mag menu
                    while(!exitDiscMenu){
                        Console.WriteLine("\nDisc Magazines\n\n" 
                        + "1. Add a Disc Magazine\n"
                        + "2. Edit a Disc Magazine\n"
                        + "3. Delete a Disc Magazine\n"
                        + "4. Sell a Disc Magazine\n\n"
                        + "Enter Selection: ");

                            int menuDiscMagazineSelection = 0;
                            menuDiscMagazineSelection = Convert.ToInt32(Console.ReadLine());

                            switch (menuDiscMagazineSelection) {
                            case 1: 
                                boolDiscMag = true;
                                AddAPublication();
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
                                Console.WriteLine("Please enter a valid choice.");
                                break;
                        }
                    }
                        break;
                    case 4:
                    // Disc Mag menu
                    while(!exitTicketMenu){
                        Console.WriteLine("\nTickets\n\n" 
                        + "1. Sell a Ticket\n"
                        + "Enter Selection: ");

                            int menuDiscMagazineSelection = 0;
                            menuDiscMagazineSelection = Convert.ToInt32(Console.ReadLine());

                            switch (menuDiscMagazineSelection) {
                            case 1: 
                                Ticket ticket = new Ticket();
                            //ticket.sellCopy();
                            //CashTill sell = new CashTill();

                            sell.sellItem(ticket);
           
                                sell.showTotal();
                                break;
                            case -1:
                                exitTicketMenu = true;
                                break;
                            default:
                                Console.WriteLine("Please enter a valid choice.");
                                break;
                        }
                    }  
                    break;
                case -1:
                    exitMenu = true;
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice.");
                    break;
                }
        }
        Environment.Exit(0);
    }
    
    public void theLine()
{
    Console.WriteLine("--------------------------------------------------");
}

// Funtion to Add publications to the lists.
public void AddAPublication()
{
        if (boolBook = true){
        //Scanner inputBook = new Scanner(System.in);

        theLine();

        Console.WriteLine("\nAdd A Book\n\n   Enter Author:");
                String author = (Console.ReadLine());

                Console.WriteLine("\n  Quantity to Order:");
        int copies;
                copies = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n  Enter Title:");
        String title = (Console.ReadLine());

                Console.WriteLine("\n  Enter Price:");
        double price;
                price = Convert.ToDouble(Console.ReadLine());

                Book book = new Book(author, copies, price, title);

        books.Add(book);
        activeBook++;
    }
        else if (boolMagazine = true){
        //Scanner inputMag = new Scanner(System.in);

        theLine();

        Console.WriteLine("\nAdd A Magazine\n\n   Enter Title:");
        String title = (Console.ReadLine());

                Console.WriteLine("\n  Enter Price:");
        double price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n  Quantity to Order:");
                int copies = 0;
        copies = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n  Enter the Date of the Issue:");
                Console.WriteLine("\n  Enter the Year");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n  Enter the Month");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n  Enter the Day");
                int day = Convert.ToInt32(Console.ReadLine());
                DateTime currIssue;
                currIssue = Convert.ToDateTime(year + "/" + month + "/" + day);

                Magazine magazine = new Magazine(title, price, copies, currIssue);

        magazines.Add(magazine);
        activeMagazine++;
    }
        else if (boolDiscMag = true){
        //Scanner inputDicsMag = new Scanner(System.in);

        theLine();

        Console.WriteLine("\nAdd A Disc Magazine\n\n   Enter Title:");
        String title = (Console.ReadLine());

                Console.WriteLine("\n  Enter Price:");
        double price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n  Quantity to Order:");
        int copies = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n  Enter the Date of the Issue:");
                Console.WriteLine("\n  Enter the Year");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n  Enter the Month");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n  Enter the Day");
                int day = Convert.ToInt32(Console.ReadLine());
                DateTime currIssue;
                currIssue = Convert.ToDateTime(year + "/" + month + "/" + day);

                Magazine discMag = new Magazine(title, price, copies, currIssue);

        discMags.Add(discMag);
        activeDiscMag++;
    }
}


// Funtion to print all the books.
public void listAllBooks()
{
    int bookNumber = 0;

    if (books.== null)
    {
        Console.WriteLine("Sorry there are no books.");
    }
    else
    {
        theLine();

        Console.WriteLine("\nAll Books\n");

        for (Lab6.Book book:books)
        {
            if (book == null)
                continue;

            Console.WriteLine("Book #: " + bookNumber);
            Console.WriteLine(book);

            bookNumber++;
        }
    }
}

// Funtion to print all the magazines.
public void listAllMags()
{
    int magNumber = 0;

    if (magazines == null)
    {
        Console.WriteLine("Sorry there are no Magazines.");
    }
    else
    {
        theLine();

        Console.WriteLine("\nAll Magazines\n");

        for (Lab6.Magazine magazine:magazines)
        {
            if (magazine == null)
                continue;

            Console.WriteLine("Magazine #: " + magNumber);
            Console.WriteLine(magazine);

            magNumber++;
        }
    }
}

// Funtion to print all the disc magazines.
public void listAllDiscMags()
{
    int discNumber = 0;

    if (discMags == null)
    {
        Console.WriteLine("Sorry there are no Disc Magazines.");
    }
    else
    {
        theLine();

        Console.WriteLine("\nAll Disc Magazines\n");

        for (Lab6.Magazine discMag:discMags)
        {
            if (discMag == null)
                continue;

            Console.WriteLine("Disc Mag #: " + discNumber);
            Console.WriteLine(discMag);

            discNumber++;
        }
    }
}

// Funtion to delete a book.
public void deleteABook()
{
    listAllBooks();

    theLine();

    if (books == null)
    {
        Console.WriteLine("Sorry there are no books.");
    }
    else
    {
        //Scanner input = new Scanner(System.in);
        Console.WriteLine("\nDelete a book\n\n  Enter book number:");
        int bookToDelete = Convert.ToInt32(Console.ReadLine());

                books.RemoveAt(bookToDelete);

    }
}

// Funtion to delete a magazine.
public void deleteAMag()
{
    listAllMags();

    theLine();

    if (magazines == null)
    {
        Console.WriteLine("Sorry there are no magazines.");
    }
    else
    {
        //Scanner input = new Scanner(System.in);
        Console.WriteLine("\nDelete a Magazine\n\n  Enter Magazine number:");
        int magToDelete = Convert.ToInt32(Console.ReadLine());

                magazines.RemoveAt(magToDelete);

    }
}

// Funtion to delete a car from the lot.
public void deleteADiscMag()
{
    listAllDiscMags();

    theLine();

    if (discMags == null)
    {
        Console.WriteLine("Sorry there are no Disc Magazines.");
    }
    else
    {
        //Scanner input = new Scanner(System.in);
        Console.WriteLine("\nDelete a Disc Magazine\n\n  Enter Disc Mag number:");
        int discToDelete = Convert.ToInt32(Console.ReadLine());

                discMags.remove(discToDelete);
    }
}

// Funtion to edit the propeties of any car in the lot.
public void editABook()
{
    listAllBooks();

    theLine();

    if (books == null)
    {
        Console.WriteLine("Sorry there are no Books.");
    }
    else
    {
        //Scanner input = new Scanner(System.in);
        Console.WriteLine("\nEdit A Book\n\n  Enter book number:");
        int bookToEdit = input.nextInt();

        Console.WriteLine("\n  Enter Author:");
        String author = input.next();

        Console.WriteLine("\n  Enter copies ordered:");
        int copies = input.nextInt();

        Console.WriteLine("\n  Enter Title:");
        String title = input.next();

        Console.WriteLine("\n  Enter price:");
        int price = input.nextInt();

        books.get(bookToEdit).setAuthor(author);
        books.get(bookToEdit).setCopies(copies);
        books.get(bookToEdit).setTitle(title);
        books.get(bookToEdit).setPrice(price);
    }
}

// Funtion to edit the propeties of any car in the lot.
public void editAMag()
{
    listAllMags();

    theLine();
        
        if (magazines == null){
        Console.WriteLine("Sorry there are no magazines.");
    }
        else{
        //Scanner input = new Scanner(System.in);
        Console.WriteLine("\nEdit A Magazine\n\n  Enter Magazine number:");
        int magToEdit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n  Enter title:");
        String title = input.next();

        Console.WriteLine("\n  Enter price:");
        double price = input.nextDouble();

        Console.WriteLine("\n  Enter the number of copies:");
        int copies = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n  Enter the Date of the Issue:");
                Console.WriteLine("\n  Enter the Year");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n  Enter the Month");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n  Enter the Day");
                int day = Convert.ToInt32(Console.ReadLine());
                DateTime currIssue;
                currIssue = Convert.ToDateTime(year + "/" + month + "/" + day);

                magazines.get(magToEdit).setTitle(title);
        magazines.get(magToEdit).setPrice(price);
        magazines.get(magToEdit).setCopies(copies);
        magazines.get(magToEdit).setCurrIssue(currIssue);
    }
}

// Funtion to edit the propeties of any car in the lot.
public void editADisc()
{
    listAllDiscMags();

    theLine();
        
        if (discMags.== null){
        Console.WriteLine("Sorry there are no Disc Magazines.");
    }
        else{
        // Scanner input = new Scanner(System.in);
        Console.WriteLine("\nEdit A Disc Magazine\n\n  Enter Disc Magazine number:");
        int magToEdit = input.nextInt();

        Console.WriteLine("\n  Enter title:");
        String title = input.next();

        Console.WriteLine("\n  Enter price:");
        double price = input.nextDouble();

        Console.WriteLine("\n  Enter the number of copies:");
        int copies = input.nextInt();

                Console.WriteLine("\n  Enter the Date of the Issue:");
                Console.WriteLine("\n  Enter the Year");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n  Enter the Month");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n  Enter the Day");
                int day = Convert.ToInt32(Console.ReadLine());
                DateTime currIssue;
                currIssue = Convert.ToDateTime(year + "/" + month + "/" + day); ;

        discMags.get(magToEdit).setTitle(title);
        discMags.get(magToEdit).setPrice(price);
        discMags.get(magToEdit).setCopies(copies);
        discMags.get(magToEdit).setCurrIssue(currIssue);
    }
}

public void sellABook()
{
    listAllBooks();

    theLine();

    if (books.== null)
    {
        Console.WriteLine("Sorry there are no Books.");
    }
    else
    {
        //Scanner input = new Scanner(System.in);
        Console.WriteLine("\nSell A Book\n\n  Enter Book number:");
        int bookToSell = input.nextInt();

        int numCopies = books.get(bookToSell).getCopies() - 1;

        books.get(bookToSell).setCopies(numCopies);

        //CashTill sell = new CashTill();

        sell.sellItem(books.get(bookToSell));

        sell.showTotal();
    }
}

public void sellAMag()
{
    listAllMags();

    theLine();

    if (magazines.== null)
    {
        Console.WriteLine("Sorry there are no Magazines.");
    }
    else
    {
        //Scanner input = new Scanner(System.in);
        Console.WriteLine("\nSell A Magazine\n\n  Enter Magazine number:");
        int magToSell = input.nextInt();

        int numCopies = magazines.get(magToSell).getCopies() - 1;

        magazines.get(magToSell).setCopies(numCopies);

        //CashTill sell = new CashTill();

        sell.sellItem(books.get(magToSell));

        sell.showTotal();
    }
}

public void sellADiscMag()
{
    listAllDiscMags();

    theLine();

    if (discMags.== null)
    {
        Console.WriteLine("Sorry there are no Disc Magazines.");
    }
    else
    {
        //Scanner input = new Scanner(System.in);
        Console.WriteLine("\nSell A Disc Magazine\n\n  Enter Disc Magazine number:");
        int discMagToSell = input.nextInt();

        int numCopies = discMags.get(discMagToSell).getCopies() - 1;

        discMags.get(discMagToSell).setCopies(numCopies);

        //CashTill sell = new CashTill();

        sell.sellItem(books.get(discMagToSell));

        sell.showTotal();
    }
}
}
}
