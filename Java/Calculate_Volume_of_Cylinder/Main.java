
package Lab2.q3;
import java.util.Scanner; 

/*
Author : Todd Pidgeon
Date : 09-22-2016
Description : Calculates the volume of a cylinder based on the radius and length which is input by the user.
*/

public class Main {

    public static void main(String[] args) {
        
        double radius;
        double length;
        double volume;
        double area;
        
        // Input
        Scanner inputRadius=new Scanner(System.in);
        System.out.println("Enter the radius of the cylinder: ");
        radius = inputRadius.nextDouble();
        
        Scanner inputLength=new Scanner(System.in);
        System.out.println("Enter the length of the cylinder: ");
        length = inputLength.nextDouble();
        
        // Process
       
        area = radius * radius * Math.PI;
        volume = area * length;
        
        // Output
        System.out.println("A cylinder of radius " + radius + " and length of " + length + " has a volume of " + volume);
        
    }
    
}
