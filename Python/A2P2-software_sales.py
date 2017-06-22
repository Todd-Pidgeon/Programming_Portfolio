
# Program Name:       A2P2-software_sales.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 05/10/2015
# Program Purpose:    Users enter in an amount of Software packages purchased, the program determines
#                     the discount if applicable and then calculates and outputs the amount of discount
#                     and the total for the purchase after the discount is applied.

import os


# Declare variables
discount = 0.0
discount_amount = 0.0
cost_of_unit = 99.00
packages_purchased = 0.0

# User Input
print('\n\t\tSoftware Sales Discount Calculator')
print('\n-------------------------------------------------------------------')
while True:
    try:
        packages_purchased = float(input('\n\tEnter the number Software Packages purchased = '))
    except ValueError:
        print('\n-------------------------------------------------------------------')
        print('\t\t****Please enter a number****')
        print('-------------------------------------------------------------------\n')
    else:
        break
print('\n-------------------------------------------------------------------')

# Check for applicable discount
if packages_purchased < 10:
    pass
elif packages_purchased <= 19:
    discount = 0.1
elif packages_purchased <= 49:
    discount = 0.2
elif packages_purchased <= 99:
    discount = 0.3
else:
    discount = 0.4


# Compute Subtotal
subtotal = packages_purchased * cost_of_unit

# Compute discount if needed and total
if discount == 0.0:
    total_of_purchase = subtotal
else:
    discount_amount = subtotal * discount
    total_of_purchase = subtotal - discount_amount

# Output
print('\n\t\tDiscount for this purchase   = $', format(discount_amount, '.2f'))
print('\n\t\tTotal for this purchase      = $', format(total_of_purchase, '.2f'))
print('\n')

os.system("pause")
