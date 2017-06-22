
package Lab2.q1;
import java.util.Scanner; 

/*
Author : Todd Pidgeon
Date : 09-21-2016
Description : Converts an input temperature from the user to the fahrenheit equvilent.
*/

public class Main {
    
    public static void main(String[] args) {
        
        // Input
        double celsius;
        double fahrenheit;
        
        Scanner input=new Scanner(System.in);
        
        System.out.println("Enter a temperature in Celsius: ");
        
        celsius = input.nextDouble();
        
        // Process
        fahrenheit = 9.0/5 * celsius + 32;
        
        //Output
        System.out.println(celsius + " degrees celsius = " + fahrenheit + " degrees fahrenheit");
    }
    
}
