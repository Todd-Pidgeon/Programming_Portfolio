
package Lab2.q2;
import java.util.Scanner; 

/*
Author : Todd Pidgeon
Date : 09-21-2016
Description : Converts an input temperature from the user to the celsius equvilent.
*/

public class Main {
    
    public static void main(String[] args) {
        
        // Input
        double celsius;
        double fahrenheit;
        
        Scanner input=new Scanner(System.in);
        
        System.out.println("Enter a temperature in fahrenheit: ");
        
        fahrenheit = input.nextDouble();
        
        // Process
        celsius = (fahrenheit - 32) * 5/9.0;
        
        //Output
        System.out.println(fahrenheit + " degrees fahrenheit = " + celsius + " degrees celsius");
    }
    
}

