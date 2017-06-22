
package lab3.q2;

import java.util.Scanner;

/**
Author : Todd Pidgeon
Date : 29/09/2016
Description : Validates a 10 digit account number.
**/

public class Main {
    
    public static void main(String[] args) {
        
        long accountNumber;
        long decheckedAccount;
        long modAccountNumber;
        long modNum1;
        long modNum2;
        long modNum3;
        long modNum4;
        long modNum5;
        long modSum;
        long checkDigit;
        long newCheckDigit;
        String validation;
        
        
        // Input
        Scanner input = new Scanner(System.in);
    
        System.out.println("Enter your account number: ");
    
        accountNumber = input.nextLong();
        
        // Process
        checkDigit = accountNumber%10;
        decheckedAccount = accountNumber/10;
        
        modNum1 = decheckedAccount%10;
        modAccountNumber = decheckedAccount/100;
        modNum2 = modAccountNumber%10;
        modAccountNumber = decheckedAccount/100;
        modNum3 = modAccountNumber%10;
        modAccountNumber = decheckedAccount/100;
        modNum4 = modAccountNumber%10;
        modAccountNumber = decheckedAccount/100;
        modNum5 = modAccountNumber%10;
        
        modNum1 = modNum1 * 2;
        if (modNum1 < 9){
            modNum1 = modNum1 - 9;
        }
        
        modNum2 = modNum2 * 2;
        if (modNum2 < 9){
            modNum2 = modNum2 - 9;
        }
        
        modNum3 = modNum3 * 2;
        if (modNum3 < 9){
            modNum3 = modNum3 - 9;
        }
        
        modNum4 = modNum4 * 2;
        if (modNum4 < 9){
            modNum4 = modNum4 - 9;
        }
        
        modNum5 = modNum5 * 2;
        if (modNum5 < 9){
            modNum5 = modNum5 - 9;
        }
        
        modSum = modNum1 + modNum2 + modNum3 + modNum4 + modNum5;
        
        modSum = modSum * 9;
        
        newCheckDigit = modSum%10;
        
        if (newCheckDigit == checkDigit){
            validation = "VALID";
        }
        else{
            validation = "INVALID";
        }
 
        // Output
        System.out.println("Account Number: " + Long.toString(accountNumber) + " is " + validation);
        
    }
}