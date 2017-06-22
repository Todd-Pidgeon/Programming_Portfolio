
package Lab5.q1;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
Author : Todd Pidgeon
Date : 23/10/2016
Description : A Car lot menu for adding, deleting, editing, and selling cars 
* from a virtual car lot.
**/



public class App {
    // Declare variables.
    private static List<Car> cars = new ArrayList<Car>();
    // If cars are added beyond the 100 set, this could be an issue for the sold car list.
    private static List<Car> soldCars = new ArrayList<Car>();;
    private static int activeCar = 0;
    private static int activeSoldCar = 0;
    
    public void run(){
        
        boolean exitMenu = false;
        
        Scanner input = new Scanner(System.in);
        
        // Main menu loop
        while(!exitMenu){
            
            theLine();
            
            System.out.println("\nUsed Car Lot\n\n" 
                    + "1. Add a car\n"
                    + "2. Sell a car\n"
                    + "3. List all cars\n"
                    + "4. Delete a car\n"
                    + "5. Edit a car\n"
                    + "6. List sold cars and their owners.\n\n"
                    + "Enter Selection: ");
            
            int menuSelection = input.nextInt();
            
            switch(menuSelection) {
                case 1: 
                    addACar();
                    break;
                case 2: 
                    sellACar();
                    break;
                case 3: 
                    listAllCars();
                    break;
                case 4:
                    deleteACar();
                    break;
                case 5: 
                    editACar();
                    break;
                case 6:
                    listSoldCars();
                    break;
                case -1:
                    exitMenu = true;
                    break;
                default:
                    System.out.println("Please enter a velid choice.");
            }
        }
        System.exit(0);
    }
    
    public void theLine() {
        System.out.println("--------------------------------------------------");
    }
    
    // Funtion to add cars to the car lot.
    public void addACar() {
        if (cars.size() >= 99){
            System.out.println("Sorry the Car Lot is full");
        }
        else{
            Scanner input = new Scanner(System.in);

            theLine();

            System.out.println("\nAdd A New Car\n\n   Enter make:");
            String make = input.next();

            System.out.println("\n  Enter model:");
            String model = input.next();

            System.out.println("\n  Enter year:");
            int year = input.nextInt();

            //String firstname = "NOT";
            //String lastname = "SET";
            //Person defaultOwner = new Person(firstname, lastname);

            Car car = new Car(make, model, year);

            cars.add(car);
            activeCar++;
        }
    }
    
    // Funtion to sell a car from the lot.
    public void sellACar() {
        listAllCars();
        
        theLine();
        
        if (cars.isEmpty()){
            System.out.println("Sorry there are no cars in the Lot.");
        }
        else{
            Scanner input = new Scanner(System.in);
            System.out.println("\nSell a car\n\n    Enter car number:");
            int carToSell = input.nextInt();

            System.out.println("\n    Enter owner's first name:");
            String firstName = input.next();

            System.out.println("\n    Enter owner's last name:");
            String lastName = input.next();

            Person newOwner = new Person(firstName, lastName);

            // Set the owner of the car.
            cars.get(carToSell).setOwner(newOwner);

            // Add the car to the Sold car array.
            soldCars.add(cars.get(carToSell));
            activeSoldCar++;

            // Remove the sold car from the lot.
            cars.remove(carToSell);

            // Loop to move any null values to the end of the array.
            /*
            for(int i = 0; i < 99; i++) {
                if (cars[i] == null) {
                    cars[i] = cars[i + 1];
                    cars[i + 1] = null;
                }
            }
            */
        }
    }
    
    // Funtion to print all the cars in the lot.
    public void listAllCars() {
        int carNumber = 0;
        
        theLine();
        
        System.out.println("\nAll Cars In Lot\n");
        
        for(Car car:cars){
            if(car==null)
                continue;
            
            System.out.println("Car: " + carNumber);
            System.out.println(car);
            
            carNumber++;
        }
    }
    
    // Funtion to delete a car from the lot.
    public void deleteACar() {
        listAllCars();
        
        theLine();
        
        if (cars.isEmpty()){
            System.out.println("Sorry there are no cars in the Lot.");
        }
        else{
            Scanner input = new Scanner(System.in);
            System.out.println("\nDelete a car\n\n  Enter car number:");
            int carToDelete = input.nextInt();

            cars.remove(carToDelete);

            // Loop to move any null values to the end of the array.
            /*
            for(int i = 0; i < 99; i++) {
                if (cars[i] == null) {
                    cars[i] = cars[i + 1];
                    cars[i + 1] = null;
                }
            }
            */
        }
    }
        
    
    // Funtion to edit the propeties of any car in the lot.
    public void editACar() {
        listAllCars();
        
        theLine();
        
        if (cars.isEmpty()){
            System.out.println("Sorry there are no cars in the Lot.");
        }
        else{
            Scanner input = new Scanner(System.in);
            System.out.println("\nEdit A Car\n\n  Enter car number:");
            int carToEdit = input.nextInt();

            System.out.println("\n  Enter make:");
            String make = input.next();

            System.out.println("\n  Enter model:");
            String model = input.next();

            System.out.println("\n  Enter year:");
            int year = input.nextInt();

            cars.get(carToEdit).setMake(make);
            cars.get(carToEdit).setModel(model);
            cars.get(carToEdit).setYear(year);
        }
    }
        
    
    // Function to print a list of all the sold cars.
    public void listSoldCars() {
        
        theLine();
        
        System.out.println("\nSold Car List\n");
        
        for(Car car:soldCars){
            if(car==null)
                continue;
            
            System.out.println(car);
        }
    }
}
