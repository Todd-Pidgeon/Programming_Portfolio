
# Program Name:       A8P1-total_sales.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 02/12/2015
# Program Purpose:    Prompts users for the week's sales data, calculates and outputs a total.

import os


def input_sales():
    # Declaration of variables
    day_of_week = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday']
    total_weekly_sales = 0.0
    sales_index = 0
    day_index = 0
    daily_sales = [0.0] * 7

    while sales_index < 7:
        while True:
            try:
                daily_sales[sales_index] = int(input('\n\t\tWhat was the total sales for ' + day_of_week[day_index] +
                                                     ': $'))
            except ValueError:
                input_error()
                continue
            else:
                break
        total_weekly_sales += daily_sales[sales_index]
        day_index += 1
        sales_index += 1

    return total_weekly_sales


def output_total(total_weekly_sales):
    line()
    print('\n\t\tThe total sales for this week are $', format(total_weekly_sales, '.2f'), sep='')


def line():
    print('\t', 60 * '_')


def input_error():
    print('\n\t', 60 * '-')
    print('\t\t****Invalid input, please enter a number****')
    print('\t', 60 * '-')


def main():
    # Main program loop.
    # Declaration of variables.
    run_again = 'y'

    while run_again.lower() == 'y' or 'yes':
        print('\n\n\t\t\tTotal Sales')
        line()

        total_weekly_sales = input_sales()
        output_total(total_weekly_sales)

        while True:
            line()
            run_again = input('\n\n\t\tDo you wish enter in another week of sales? (y/n): ')
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
