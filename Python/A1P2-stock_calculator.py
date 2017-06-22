
# Program Name:       A1P2-stock_calculator.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 28/09/2015
# Program Purpose:    Calculate and display stock purchase and sale made by the user
#                     as well as the commission fees paid.

import os

print('\n\t\t\tStock Calculator\n')
print('------------------------------------------------------------------------------')

# Input for Stock purchase
number_of_shares = 2000.00
stock_price = 40.00
buy_commission = 0.03

# Input for Stock sale
shares_sold = 2000.00
sale_price = 42.75
sale_commission = 0.03

# Calculations for purchase
amount_paid = (number_of_shares*stock_price)
buy_commission_paid = (amount_paid*buy_commission)
# Calculations for sale
sold_amount = (shares_sold*sale_price)
sale_commission_paid = (sold_amount*sale_commission)
# Calculation of total after commission paid
amount_left = (sold_amount-buy_commission_paid-sale_commission_paid)

# Output of Data
print('\tAmount Paid for Stock:                           $', format(amount_paid, '.2f'))
print('\n\tAmount of Commission Paid for Buying the Stock:  $', format(buy_commission_paid, '.2f'))
print('\n\tAmount the Stock Was Sold for:                   $', format(sold_amount, '.2f'))
print('\n\tAmount of Commission Paid for Selling the Stock: $', format(sale_commission_paid, '.2f'))
print('\n\tAmount Left After Fees Are Paid:                 $', format(amount_left, '.2f'))
print('------------------------------------------------------------------------------\n')

os.system("pause")
