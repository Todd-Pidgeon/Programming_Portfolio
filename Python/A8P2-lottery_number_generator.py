
# Program Name:       A8P2-lottery_number_generator.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 02/12/2015
# Program Purpose:    Generates a set of 7 numbers randomly between 0 and 9.

import os
import random


def lottery_generator():
    lottery_numbers = [0] * 7

    for x in range(0, 7):
        lottery_numbers[x] = random.randint(0, 9)

    return lottery_numbers


def output_numbers(lottery_numbers):

    print('\n\t\tThe Lottery Numbers are:')
    line()
    print('')

    for n in lottery_numbers:
        print('\t\t', n)


def line():
    print('\t', 60 * '_')


def main():
    # Main program loop.
    # Declaration of variables.
    run_again = 'y'

    while run_again.lower() == 'y' or 'yes':
        lottery_numbers = lottery_generator()
        output_numbers(lottery_numbers)

        while True:
            line()
            run_again = input('\n\n\t\tDo you wish generate a new set of numbers? (y/n): ')
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


