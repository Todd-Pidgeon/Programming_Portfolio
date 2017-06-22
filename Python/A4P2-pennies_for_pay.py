
# Program Name:       A4P2-pennies_for_pay.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 29/10/2015
# Program Purpose:    Asks the user for an amount of days then starts with a penny and doubles
#                     it each day, then totals that all up.

import os


def line():  # Function for display.
    print('\t_____________________________________________________________\n')

# Main program loop.
while True:
    # Declaration of variables.
    daily_wage = 0.01
    money_earned = 0
    total_earned = 0
    number_of_days = 0
    shall_continue = ''

    # Title display
    print('\n\t\t\t\tPennies For Pay')
    line()

    # User input loop for number of days to account for. The loop is used for input validation.
    while True:
        try:
            number_of_days = int(input('\t  How Many days worked do you wish to calculate? : '))
            line()
        except ValueError:
            print('\n\t-------------------------------------------------------------')
            print('\t\t\t****Please enter a number****')
            print('\t-------------------------------------------------------------\n')
        else:
            break

    # Loop to repeat the calculation and output for the number of days specified.
    for date in range(1, number_of_days + 1):
        print('\t\tDay ', date, ' = $', format(daily_wage, '.2f'), sep='')
        total_earned += daily_wage
        daily_wage *= 2

    # Output of the total amount earned.
    line()
    print('\t\tThe total amount earned in ', date, ' days is $', format(total_earned, '.2f'), sep='')

    # Main program re-run loop. With input validation.
    while True:
        line()
        shall_continue = input('\n\tDo you wish to try again? (y/n): ')
        if shall_continue in ('y', 'n'):
            os.system('cls')
            break
        print('\n\t-------------------------------------------------------------------')
        print('\t\t\tInvalid input, please enter (y/n)')
        print('\t-------------------------------------------------------------------\n')
    if shall_continue == 'y':
        os.system('cls')
        continue
    else:
        print('\n\t\tGoodbye')
        line()
        break

print('')
os.system("pause")
