
# Program Name:       A3P2-hotel_occupancy.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 02/11/2015
# Program Purpose:

import os

number_of_floors = 0
occupied_rooms = 0
number_of_rooms = 0
total_rooms = 0
total_occupied = 0
total_unoccupied = 0
occupancy_rate = 0
floor = 1
run_again = 'y'


def input_error():
    print('\n\t-----------------------------------------------------------------')
    print('\t\t****Invalid input, please enter valid choice****')
    print('\t-----------------------------------------------------------------')


def line():
    print('\t_________________________________________________________________')

# Main program loop.
while run_again == 'y':
    print('\n\t\t\t\tHotel Occupancy')
    line()
    print('')
    # User inputs how many floor the hotel has, Must be more then 1 but no more than 20
    # User must also enter in a number.
    while True:
        try:
            number_of_floors = int(input("\n\t\tNumber of floors: "))
            if number_of_floors >= 4:
                number_of_floors += 1
            if number_of_floors >= 13:
                number_of_floors += 1
        except ValueError:
                input_error()
                continue
        while number_of_floors < 1 or number_of_floors > 20:
            input_error()
            break
        else:
                break

    line()

    # Will prompt for the number of rooms and rooms occupied for each floor based on the amount of floors
    # input above. Will also exclude floors 4 and 13.
    for floor in range(1, number_of_floors + 1):
        if floor == 4 or floor == 13:
            continue
        while True:
            try:
                number_of_rooms = int(input('\n\t\tNumber of rooms on floor ' + str(floor) + ' : '))
                if number_of_rooms < 1 or number_of_rooms > 10:
                    input_error()
                    continue
            except ValueError:
                input_error()
                continue
            else:
                break
        while True:
            try:
                occupied_rooms = int(input('\t\tNumber of occupied rooms   : '))
                if occupied_rooms > number_of_rooms:
                    input_error()
                    continue
            except ValueError:
                input_error()
                continue
            else:
                break
        total_rooms += number_of_rooms
        total_occupied += occupied_rooms
        total_unoccupied = total_rooms - total_occupied
        occupancy_rate = (total_occupied / total_rooms) * 100
    line()
    print('\n\t\tTotal number of rooms      : ', total_rooms)
    print('\t\tNumber of occupied rooms   : ', total_occupied)
    print('\t\tNumber of unoccupied rooms : ', total_unoccupied)
    print('\t\tOccupancy rate             : ', format(occupancy_rate, '.1f'), '%')

    while True:
        line()
        run_again = input('\n\tDo you wish to run the program again? (y/n): ')
        if run_again in ('y', 'n'):
            os.system('cls')
            break
        print('\n\t-----------------------------------------------------------------')
        print('\t\t****Invalid input, please enter (y/n)****')
        print('\t-----------------------------------------------------------------')
    if run_again == 'y':
        os.system('cls')
        continue
    else:
        print('')
        line()
        print('\n\t\tGoodbye')
        break

print('\n\n')
os.system("pause")
