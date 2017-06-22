
# Program Name:       A7P1-commissions_rate_2.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 26/11/2015
# Program Purpose:    Calculates the commission rate of Salesperson's that the user enters.


import os
import salesperson_data

# Functions


def calculate_commission(sales):

    COMMISSION_1 = 0.05
    COMMISSION_2 = 0.1
    COMMISSION_3 = 0.2

    if sales <= 1000:
        commission_rate = sales * COMMISSION_1

    elif sales <= 2000:
        commission_rate = sales * COMMISSION_2
    else:
        commission_rate = sales * COMMISSION_3

    return commission_rate


def determine_bonus(commission_rate, years_worked):

    BONUS_YEARS = 10
    final_commission = commission_rate

    if years_worked > BONUS_YEARS:
        final_commission = commission_rate * 2

    return final_commission


def output_commission(name, final_commission):

    line()
    print("\n\n")
    print("{a:10s} {b:^42s}" .format(a="", b="COMMISSION REPORT"))
    line()
    print('\n')
    print("{a:10s} {b:<20s} {c:5s} {d:>17s}" .format(a="", b="SALESPERSON NAME", c="", d="COMMISSION AMOUNT"))
    line()
    print('\n')
    print("{a:10s} {b:<20s} {c:5s} {d:>17.2f}$" .format(a="", b=name, c="", d=final_commission))


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

        name, sales, years_worked = salesperson_data.input_salesperson_data()
        commission_rate = calculate_commission(sales)
        final_commission = determine_bonus(commission_rate, years_worked)
        output_commission(name, final_commission)

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
