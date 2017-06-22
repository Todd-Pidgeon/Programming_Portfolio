
# Program Name:       diceroll.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 19/10/2015
# Program Purpose:    Users can choose the amount and type of dice to roll and the program will output the rolls

import os
import random

# Declaration of variables
menu_option = 0
dice_type = 1
dice_amount = 1
random_number = 0
die_count = 0
dice_name = ''
exit_question = ''

# Functions
# Input Validation error message


def menu_error():
    print('\n\t-------------------------------------------------------------------')
    print('\t\t****Incorrect input, please enter valid choice****')
    print('\t-------------------------------------------------------------------\n')

# Function to return to the main menu


def main_menu():
    global dice_name
    global dice_type

    os.system('cls')

    if dice_type == 1:
        dice_name = 'D6'
    elif dice_type == 2:
        dice_name = 'D8'
    elif dice_type == 3:
        dice_name = 'D10'
    elif dice_type == 4:
        dice_name = 'D12'
    elif dice_type == 5:
        dice_name = 'D20'

    print('\n\t\t\tTodd\'s Dice Rolling Program!')
    print('\t____________________________________________________________')
    print('\n\t1.\t    Choose your dice type ( Currently,', dice_name,
          ')\n\t2.\t    How many dice to roll? ( Currently,', dice_amount,
          ') \n\t3.\t    Roll the dice\n\t4.\t    Exit Program')

    while True:
        try:
            global menu_option

            menu_option = int(input('\n\tOption: '))
            while menu_option not in (1, 2, 3, 4):
                menu_error()
                menu_option = int(input('\n\tOption: '))
        except ValueError:
            menu_error()
        else:
            break


def roll():
    global random_number
    global dice_type
    global die_count

    die_count += 1

    if dice_type == 1:
        random_number = random.randint(1, 6)
        print('\tDie', die_count, '  = ', random_number)
    elif dice_type == 2:
        random_number = random.randint(1, 8)
        print('\tDie', die_count, '  = ', random_number)
    elif dice_type == 3:
        random_number = random.randint(1, 9)
        print('\tDie', die_count, '  = ', random_number)
    elif dice_type == 4:
        random_number = random.randint(1, 12)
        print('\tDie', die_count, '  = ', random_number)
    elif dice_type == 5:
        random_number = random.randint(1, 20)
        print('\tDie', die_count, '  = ', random_number)


def re_roll():

    global die_count
    global dice_amount
    global dice_name

    os.system('cls')
    print('\n\t\t\tRolling', dice_amount, ',', dice_name)
    print('\t_______________________________________________________\n')
    for _ in range(dice_amount):
        roll()
    die_count = 0

while True:

    # Program start
    # Run the Main Menu
    main_menu()

    # Menu option 1 - Choose die type
    while True:
        os.system('cls')
        if menu_option == 1:
            print('\n\t\t\tChoose your dice type.')
            print('\t____________________________________________________________')
            print('\n\t1.\tD6\n\t2.\tD8\n\t3.\tD10\n\t4.\tD12\n\t5.\tD20')
            while True:
                try:
                    dice_type = int(input('\n\tOption: '))
                    while dice_type not in (1, 2, 3, 4, 5):
                        menu_error()
                        dice_type = int(input('\n\tOption: '))
                    main_menu()
                except ValueError:
                    menu_error()
                else:
                    break

        # Menu option 2 - Choose the amount of dice
        if menu_option == 2:
            os.system('cls')
            while True:
                try:
                    print('\n\t\tChoose the number of dice you wish to roll.')
                    print('\t____________________________________________________________')
                    dice_amount = int(input("\n\tHow many dice?: "))
                    main_menu()
                except ValueError:
                            menu_error()
                else:
                    break
        # Menu option 3 - Roll the dice
        if menu_option == 3:
            re_roll()
            break

        if menu_option == 4:
            print('\n\t-------------------------------------------------------------------')
            print('\n\tGoodbye')
            break
    if menu_option == 4:
        break

    # Prompt user if they wish to return to main menu
    while True:
        while True:
            exit_question = input('\n\tDo you wish to roll again? (y/n): ')
            if exit_question in ('y', 'n'):
                break
            print('\n\t-------------------------------------------------------------------')
            print('\t\t\tInvalid input, please enter (y/n)')
            print('\t-------------------------------------------------------------------\n')
        if exit_question == 'y':
                re_roll()
        elif exit_question == 'n':
            break
print('\n\n')
os.system('pause')
