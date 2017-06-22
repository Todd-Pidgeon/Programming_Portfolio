
# Program Name:       A3P2-distance_converter.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 14/10/2015
# Program Purpose:    Users make a choice from menu then enter in a distance in miles or kilometers and
#                     it is then converted to the opposite format.

import os


def menu_error():
    print('\n\t-------------------------------------------------------------------')
    print('\t\t****Incorrect choice, please enter 1, 2, or 3****')
    print('\t-------------------------------------------------------------------\n')


def input_error():
    print('\n\t-------------------------------------------------------------------')
    print('\t\t\t****Please enter a number****')
    print('\t-------------------------------------------------------------------\n')


while True:
    # Declaration of variables
    one_kilometer = 1.609344
    one_mile = 0.6213711
    option = 0
    distance_kilometers = 0
    distance_miles = 0
    shall_continue = ''

    # Program header and main menu
    print('\n\t\tDistance Conversion System\n\n\t1.\t	Convert Kilometers to Miles\n\t2.\t	Convert Miles to Kilometers'
          '\n\t3.\t	Exit Program')

    # User's menu choice
    while True:
        try:
            option = int(input('\n\tOption: '))
            while option not in (1, 2, 3):
                menu_error()
                option = int(input('\n\tOption: '))
        except ValueError:
            menu_error()
        else:
            break

    # Option 1 - Convert from kilometers to miles
    if option == 1:
        while True:
            try:
                print('\n\t-------------------------------------------------------------------')
                distance_kilometers = float(input('\n\tEnter the distance in kilometers: '))
            except ValueError:
                input_error()
            else:
                break
        km_to_miles = distance_kilometers * one_mile
        print('\n\t-------------------------------------------------------------------')
        print('\t', format(distance_kilometers, ',.1f'), "kilometers is equivalent to", format(km_to_miles, ',.1f')
              , 'miles') 
        print('\t-------------------------------------------------------------------\n')

    # Option 2 - Convert from miles to kilometers
    elif option == 2:
        while True:
            try:
                print('\n\t-------------------------------------------------------------------')
                distance_miles = float(input('\n\tEnter the distance in miles: '))
            except ValueError:
                input_error()
            else:
                break
        miles_to_km = distance_miles * one_kilometer
        print('\n\t-------------------------------------------------------------------')
        print('\t', format(distance_miles, ',.1f'), "miles is equivalent to",
              format(miles_to_km, ',.1f'), 'kilometers')
        print('\t-------------------------------------------------------------------\n')

    # Option 3 - Exit program
    elif option == 3:
                print('\n\t-------------------------------------------------------------------')
                print('\n\t\tGoodbye')
                break

    os.system('pause')
    os.system('cls')

print('\n\n')
os.system('pause')
