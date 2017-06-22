
# Program Name:       A2P1-money_counting_game.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 05/10/2015
# Program Purpose:    Users enter in amounts of different coins and the program calculates
#                     if the amounts entered add up to $1.00 or not.

import os

# Declare variables
number_of_pennies = 0
number_of_nickels = 0
number_of_dimes = 0
number_of_quarters = 0

print('\n\tEnter any amount of different coins that will add up to $1.00')
print('-----------------------------------------------------------------------------')

# Input the number of different coins, will fail state if wrong input type detected
while True:
    try:
        number_of_pennies = float(input('\n\t\t\tEnter the number of Pennies   = '))
    except ValueError:
        print('\n-------------------------------------------------------------------')
        print('\t\t****Please enter a number****')
        print('-------------------------------------------------------------------\n')
    else:
        break

while True:
    try:
        number_of_nickels = float(input('\t\t\tEnter the number of Nickels   = '))
    except ValueError:
        print('\n-------------------------------------------------------------------')
        print('\t\t****Please enter a number****')
        print('-------------------------------------------------------------------\n')
    else:
        break

while True:
    try:
        number_of_dimes = float(input('\t\t\tEnter the number of Dimes     = '))
    except ValueError:
        print('\n-------------------------------------------------------------------')
        print('\t\t****Please enter a number****')
        print('-------------------------------------------------------------------\n')
    else:
        break

while True:
    try:
        number_of_quarters = float(input('\t\t\tEnter the number of Quarters  = '))
    except ValueError:
        print('\n-------------------------------------------------------------------')
        print('\t\t****Please enter a number****')
        print('-------------------------------------------------------------------\n')
    else:
        break

print('\n-----------------------------------------------------------------------------')

# Declare values of coins
penny = 0.01
nickel = 0.05
dime = 0.10
quarter = 0.25

# Compute for total of coins
total_pennies = penny * number_of_pennies
total_nickels = nickel * number_of_nickels
total_dimes = dime * number_of_dimes
total_quarters = quarter * number_of_quarters

# Add up totals
total_amount = total_pennies + total_nickels + total_dimes + total_quarters


# Check total to see if the user wins
if total_amount == 1.00:
    print('\n\t\tCONGRATULATIONS!!! That adds up to $1.00, You Win!!!')
elif total_amount > 1.00:
    print('\n\t\tSorry, your amount is more than $1.00')
elif total_amount < 1.00:
    print('\n\t\tSorry, your amount is less than $1.00')

print('\n')

os.system("pause")
