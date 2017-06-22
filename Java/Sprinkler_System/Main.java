
package lab3.q3;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;
import java.util.Scanner;

/**
Author : Todd Pidgeon
Date : 02/10/2016
Description : Allows user to set time and day intervals to control a sprinkler system.
**/

public class Main {
    
    public static void main(String[] args) {
        // Global variables
        int menuSelect;
        boolean menuExit = false;
        boolean menuGo1 = false;
        boolean menuGo2 = false;
        
        String datePattern = "MMM-dd-yyyy";
        String timePattern = "hh:mmaa";
        String timeAndDatePattern = "MMM-dd-yyyy hh:mmaa";
        SimpleDateFormat dateFormat = new SimpleDateFormat(datePattern);
        SimpleDateFormat timeFormat = new SimpleDateFormat(timePattern);
        SimpleDateFormat timeAndDateFormat = new SimpleDateFormat(timeAndDatePattern);
        Calendar currentDate = new GregorianCalendar();
        Date todayDate = new Date();
        String todayTime = timeFormat.format(todayDate);
        Date todayTimeFinal = new Date();
        Date startDate = new Date();
        Date endDate = new Date();
        Date startTime = new Date();
        Date endTime = new Date();
        
        // Menu Loop
        while(menuExit == false){
            
            // Input
            Scanner menuInput = new Scanner(System.in);
            
            // Print menu
            System.out.println("");
            System.out.println(dateFormat.format(currentDate.getTime()));
            
            // Checks for date input
            if(menuGo1 == false){
                System.out.println("Sprinkler Interval Dates: from Not Set to Not Set");
            }
            else{
               System.out.println("Sprinkler Interval Dates: from " + dateFormat.format(startDate) + " to " + dateFormat.format(endDate)); 
            }
            
            // Checks for time input
            if(menuGo2 == false){
                System.out.println("Sprinkler Interval Times: from Not Set to Not Set");
            }
            else{
               System.out.println("Sprinkler Interval Times: from " + timeFormat.format(startTime) + " to " + timeFormat.format(endTime));
            }

            // Compares input date to current date if input was processed
            if(menuGo1 && menuGo2 == false){
                System.out.println("Sprinkler is off");
            }
            else if(startDate.before(todayDate) && endDate.after(todayDate)){
                // convert current time to time format only
                try{
                todayTimeFinal = timeFormat.parse(todayTime);
                }
                catch (ParseException e){
                    
                }
                // Turn on sprinkler if the current time is between the set times.
                if(startTime.before(todayTimeFinal) && endTime.after(todayTimeFinal)){
                    System.out.println("Sprinkler is on");
                }
                else{
                System.out.println("Sprinkler is off");
                }
            }
            else{
                System.out.println("Sprinkler is off");
            }
            
            
            System.out.println("1. Set dates for the sprinkler interval");
            System.out.println("2. Set sprinkler ON/OFF times");
            System.out.println("3. Set test date and time");
            System.out.println("99. Quit");
            System.out.println("");
            System.out.println("Menu Selection: ");
        
            menuSelect = menuInput.nextInt();

            // Menu select switch
            switch (menuSelect) {
                case 1:
                    menuGo1 = true;
                    System.out.println("");
                    System.out.println("Enter date and time in the format MMM-dd-yyyy");
                    System.out.println("For example, it is now " + dateFormat.format(currentDate.getTime()));
                    System.out.println("Enter the start date Sprinkler will be active");
                    startDate = getDate(dateFormat);
                    System.out.println("Enter the end  date Sprinkler will be active");
                    endDate = getDate(dateFormat);
                    System.out.println("Start Date entered = " + dateFormat.format(startDate));
                    System.out.println("End Date entered = " + dateFormat.format(endDate));

                    break;
                case 2:
                    menuGo2 = true;
                    System.out.println("");
                    System.out.println("Enter time in the format hh:mmaa");
                    System.out.println("For example, it is now " + timeFormat.format(currentDate.getTime()));
                    System.out.println("Enter the start time Sprinkler will be active");
                    startTime = getDate(timeFormat);
                    System.out.println("Enter the end time Sprinkler will be active");
                    endTime = getDate(timeFormat);
                    break;
                case 3:
                    System.out.println("");
                    System.out.println("Enter test date and time in the format MMM-dd-yyyy hh:mmaa");
                    System.out.println("For example, it is now " + timeAndDateFormat.format(currentDate.getTime()));
                    System.out.println("Enter the test date and time");
                    Date testDateTime = getDate(timeAndDateFormat);
                    System.out.println("Test Date and Time entered = " + timeAndDateFormat.format(testDateTime));
                    break;
                case 99:
                    System.out.println("Goodbye.");
                    menuExit = true;
                    break;
                default:
                    System.out.println("Error, try again.");
                    break;
            }
        }
    }

    // Validates user input
    private static Date getDate(SimpleDateFormat format) {
        Date date = null;
        Scanner input = new Scanner(System.in);
        while (date == null) {
            String line = input.nextLine();
            try {
                date = format.parse(line);
            } catch (ParseException e) {
                System.out.println("Sorry, that's not valid. Please try again.");
            }
        }
        return date;
    }
}