
# Program Name:       A5P1-guessing_game_revisited.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 14/10/2015
# Program Purpose:    Users have three attempts to guess a randomly generated number

import os
import random

# Declaration of variables
run_again = 'y'
guess = 0

# Main program loop
while run_again == 'y':

    # Functions
    def input_error():
        global random_number

        if attempt < 3:
            print('\n\t-------------------------------------------------------------------')
            print('\t\t****That cost you a guess, Please enter a number****')
            print('\t-------------------------------------------------------------------\n')
        else:
            no_more()

    def too_high():
        print('\n\t-------------------------------------------------------------------')
        print('\t\t\tSorry, too high\n\t\t\tTry again.')
        print('\t-------------------------------------------------------------------')

    def too_low():
        print('\n\t-------------------------------------------------------------------')
        print('\t\t\tSorry, too low\n\t\t\tTry again.')
        print('\t-------------------------------------------------------------------')

    def no_more():
        global random_number

        print('\n\t-------------------------------------------------------------------')
        print('\t\t\tSorry, you have no more guesses.')
        print('\t\t\tThe number is %i.' % random_number)
        print('\t-------------------------------------------------------------------')

    def congrats():
        global guess
        global attempt

        if attempt == 1:
            print('\n\t-------------------------------------------------------------------')
            print("\t\t\tCongratulations, you got it!")
            print('\t\t\tYou guessed the number in', attempt, "try.")
            print('\t-------------------------------------------------------------------')
        else:
            print('\n\t-------------------------------------------------------------------')
            print("\t\t\tCongratulations, you got it!")
            print('\t\t\tYou guessed the number in', attempt, "tries.")
            print('\t-------------------------------------------------------------------')

    # Random number roll
    random_number = random.randint(1, 10)
    print('\n\n\t\t\t\tThe Guessing Game')
    print('\t_________________________________________________________________')
    print('\n\t   Guess a number between 1 and 10, you have three chances.')
    print('\t_________________________________________________________________')
    # User has 3 attempts to guess the random number
    for attempt in range(1, 4):
        try:
            guess = int(input('\n\t\t\tGuess the number: '))
        except ValueError:
            input_error()
            continue
        if guess == random_number:
            congrats()
            break
        if attempt != 3:
            if guess > random_number:
                too_high()
            elif guess < random_number:
                too_low()
        else:
            no_more()
            break

    # Prompt user if they wish to play again or not
    while True:
        run_again = input('\n\tDo you wish to play again? (y/n): ')
        if run_again in ('y', 'n'):
            os.system('cls')
            break
        print('\n\t-------------------------------------------------------------------')
        print('\t\t\tInvalid input, please enter (y/n)')
        print('\t-------------------------------------------------------------------\n')
    if run_again == 'y':
        os.system('cls')
        continue
    else:
        print('\n\n\t_________________________________________________________________')
        print('\n\t\tGoodbye')
        break

print('\n\n')
os.system("pause")
