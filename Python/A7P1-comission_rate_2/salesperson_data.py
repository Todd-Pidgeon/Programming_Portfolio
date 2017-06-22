
# Program Name:       salesperson_data.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 23/11/2015
# Program Purpose:    Function to prompt user for Salesperson data to be enter and used in the Commission Rate program


def input_salesperson_data():

    sales = 0.00
    years_worked = 0

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

    return name, sales, years_worked


def input_error():
    print('\n\t', 60 * '-')
    print('\t\t****Invalid input, please a number****')
    print('\t', 60 * '-')
