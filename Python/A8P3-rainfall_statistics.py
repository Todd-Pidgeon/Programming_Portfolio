
# Program Name:       A8P2-lottery_number_generator.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 02/12/2015
# Program Purpose:    Generates a set of 7 numbers randomly between 0 and 9.

import os


def line():
    print('\t', 60 * '_')


def input_error():
    print('\n\t', 60 * '-')
    print('\t\t****Invalid input, please enter a number****')
    print('\t', 60 * '-')


def month_input():
    months = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October',
              'November', 'December']
    monthly_rainfall = [0.0] * 12
    month_index = 0
    rainfall_index = 0
    total_rainfall = 0.0

    print('\n\t\t\tRainfall Statistics')
    line()
    print('')

    while month_index < 12:
        while True:
            try:
                monthly_rainfall[rainfall_index] = int(input('\t\tEnter the total rainfall for the month of ' +
                                                             months[month_index] + ': '))
            except ValueError:
                input_error()
                continue
            else:
                break
        total_rainfall += monthly_rainfall[rainfall_index]
        month_index += 1
        rainfall_index += 1

    return total_rainfall, monthly_rainfall, months


def calc_average(total_rainfall):

    average_rainfall = total_rainfall / 12

    return average_rainfall


def min_max_month_finder(monthly_rainfall, months):
    min_months = ['']
    max_months = ['']

    for z in range(0, 12):
        while monthly_rainfall[z] == min(monthly_rainfall):
            min_months.append(months[z])
            break

    for i in range(0, 12):
        while monthly_rainfall[i] == max(monthly_rainfall):
            max_months.append(months[i])
            break

    return min_months, max_months


def data_output(average_rainfall, total_rainfall, monthly_rainfall, min_months, max_months):
    print()
    line()
    print('\n\t\tThe total rainfall for the year is ', format(total_rainfall, '.1f'), 'mm.', sep='')
    print('\t\tThe average rainfall for the year is ', format(average_rainfall, '.1f'), 'mm.', sep='')
    if min(monthly_rainfall) == max(monthly_rainfall):
        print('\t\tAll 12 months have the same rainfall with',  format(max(monthly_rainfall), '.1f'), 'mm.')
    else:
        print('\t\tThe lowest amount of rainfall was ', format(min(monthly_rainfall), '.1f'), 'mm in', sep='', end='')
        print(*min_months, sep=', ', end='')
        print('.')
        print('\t\tThe highest amount of rainfall was ', format(max(monthly_rainfall), '.1f'), 'mm in', sep='', end='')
        print(*max_months, sep=', ', end='')
        print('.')


def main():
    # Main program loop.
    # Declaration of variables.
    run_again = 'y'

    while run_again.lower() == 'y' or 'yes':

        total_rainfall, monthly_rainfall, months = month_input()
        average_rainfall = calc_average(total_rainfall)
        min_months, max_months = min_max_month_finder(monthly_rainfall, months)
        data_output(average_rainfall, total_rainfall, monthly_rainfall, min_months, max_months)

        while True:
            line()
            run_again = input('\n\n\t\tDo you wish enter a new set of data? (y/n): ')
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
