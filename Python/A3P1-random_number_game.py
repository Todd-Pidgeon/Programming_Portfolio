
# Program Name:       A3P1-random_number_game.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 02/11/2015
# Program Purpose:    Users have three attempts to guess a randomly generated number

import os
import random
# Loops are only used here to check for input validation and to rerun the program if desired
while True:

    # Declaration of variables
    guesses = 0
    guess_2 = 0
    guess_3 = 0
    shall_continue = ""

    def input_error():
        print('\n\t-------------------------------------------------------------------')
        print('\t\t\t****Please enter a number****')
        print('\t-------------------------------------------------------------------\n')

    def too_high():
        print('\n\t-------------------------------------------------------------------')
        print('\t\tSorry, too high\n\t\tTry again.')
        print('\t-------------------------------------------------------------------')

    def too_low():
        print('\n\t-------------------------------------------------------------------')
        print('\t\tSorry, too low\n\t\tTry again.')
        print('\t-------------------------------------------------------------------')

    def congrats():
        print('\n\t-------------------------------------------------------------------')
        print("\t\t\tCongratulations, you got it!")
        print('\t\t\tYou guessed the number in', guesses, "tries.")
        print('\t-------------------------------------------------------------------')

    # Random number roll
    random_number = random.randint(1, 10)

    print('\n\t   Guess a number between 1 and 10, you have three chances.')
    print('\t--------------------------------------------------------------')

    # Guess 1
    while True:
        try:
            guess_1 = int(input('\n\t\t\tGuess the number: '))
        except ValueError:
            input_error()
        else:
            break

    guesses += 1

    if guess_1 == random_number:
        print('\n\t-------------------------------------------------------------------')
        print("\t\t\tCongratulations, you got it!")
        print('\t\t\tYou guessed the number in', guesses, "try.")
        print('\t-------------------------------------------------------------------')
        pass
    elif guess_1 > random_number:
        too_high()
    elif guess_1 < random_number:
        too_low()

    # Guess 2
    if guess_1 == random_number:
        pass
    else:
        while True:
            try:
                guess_2 = int(input('\n\t\t\tGuess the number: '))
            except ValueError:
                input_error()
            else:
                break

        guesses += 1

        if guess_2 == random_number:
            congrats()
            pass
        elif guess_2 > random_number:
            too_high()
        elif guess_2 < random_number:
            too_low()

    # Guess 3
    if (guess_1 == random_number) or (guess_2 == random_number):
        pass
    else:
        while True:
            try:
                guess_3 = int(input('\n\t\t\tGuess the number: '))
            except ValueError:
                input_error()
            else:
                    break

        guesses += 1

        if guess_3 == random_number:
            congrats()
        else:
            print('\n\t-------------------------------------------------------------------')
            print('\t\tSorry, you have no more guesses.')
            print('\t\tThe number is ', random_number, '.', sep='')
            print('\t-------------------------------------------------------------------')

# Prompt user if they wish to play again or not
    while True:
        shall_continue = input('\n\tDo you wish to play again? (y/n): ')
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
        print('\n-------------------------------------------------------------------')
        print('\n\t\tGoodbye')
        break

print('\n\n')
os.system("pause")
