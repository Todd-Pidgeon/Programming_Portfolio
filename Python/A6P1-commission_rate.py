
# Program Name:       A6P1-commissions_rate.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 20/11/2015
# Program Purpose:    Calculates the commission rate of Salesperson's that the user enters.


import os

# Global variables
name = ''
sales = 0.0
years_worked = 0
commission_rate = 0.0

# Functions


def input_salesperson_data():

    global name, sales, years_worked

    name = input('\n\n\t  What is the Salesperson\'s name................?: ')

    while True:
        try:
            sales = float(input('\n\t  What is the Salesperson\'s amount of sales.....?: $'))
        except ValueError:
            input_error()
            continue
        else:
            break

    while True:
        try:
            years_worked = int(input('\n\t  How many years has they worked for the company?: '))
        except ValueError:
            input_error()
            continue
        else:
            break


def calculate_commission():
    global commission_rate

    if sales <= 1000:
        commission_rate = sales * 0.05
    elif sales <= 2000:
        commission_rate = sales * 0.1
    else:
        commission_rate = sales * 0.2


def determine_bonus():
    global commission_rate

    if years_worked > 10:
        commission_rate *= 2


def output_commission():

    print('\n\n\t\t\tCOMMISSION REPORT')
    line()
    print('\n\t\tSALESPERSON NAME\t/\tCOMMISSION AMOUNT')
    line()
    print('\n\t\t {:s}' .format(name) .ljust(40) + '${:.1f}' .format(commission_rate))


def line():
    print('\t', 60 * '_')


def input_error():
    print('\n\t', 60 * '-')
    print('\t\t****Invalid input, please a number****')
    print('\t', 60 * '-')


def main():
    # Main program loop.
    # Declaration of variables.
    run_again = 'y'

    while run_again.lower() == 'y' or 'yes':
        print('\n\n\t\t\tCommission Calculator')
        line()
        input_salesperson_data()
        calculate_commission()
        determine_bonus()
        output_commission()

        while True:
            line()
            run_again = input('\n\n\tDo you wish enter in another Salesperson? (y/n): ')
            if run_again.lower() in ('y', 'n', 'yes', 'no'):
                os.system('cls')
                break
            print('\n\t', 60 * '-')
            print('\t\t****Invalid input, please enter (y/n)****')
            print('\t', 60 * '-')
        if run_again.lower() in ('y', 'yes'):
            os.system('cls')
            continue
        else:
            print('')
            line()
            print('\n\t\tGoodbye')
            break

    print('\n\n')
    os.system("pause")

main()
