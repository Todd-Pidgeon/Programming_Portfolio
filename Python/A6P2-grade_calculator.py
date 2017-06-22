
# Program Name:       A6P2-grade_calculator.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 20/11/2015
# Program Purpose:    Determines the numeric average and letter grade for students based on the  data input.

import os

# Global variables
total_students = 0
total_average = 0
grade = 0.0
student_name = ''
grade_1 = 0.0
grade_2 = 0.0
grade_3 = 0.0
test = 1
letter_grade = ''
total_students = 0
total_average = 0.0


def input_student_data():
    global grade, student_name, grade_1, grade_2, grade_3, test

    student_name = input('\n\n\t\tWhat is the student\'s name....? : ')

    while True:
        try:
            grade = float(input('\n\t\tWhat was their grade on test ' + str(test) + '? : '))
            if grade < 0 or grade > 100:
                input_error()
                continue
        except ValueError:
            input_error()
            continue

        if test == 1:
            grade_1 = grade
        elif test == 2:
            grade_2 = grade
        elif test == 3:
            grade_3 = grade
        test += 1
        if test == 4:
            break


def compute_average():
    global average_grade

    average_grade = (grade_1 + grade_2 + grade_3) / 3


def determine_letter_grade():
    global letter_grade

    if average_grade >= 80:
        letter_grade = 'A'
    elif average_grade >= 70:
        letter_grade = 'B'
    elif average_grade >= 60:
        letter_grade = 'C'
    elif average_grade >= 50:
        letter_grade = 'D'
    else:
        letter_grade = 'F'


def output_student_data():
    global student_name, average_grade, average_grade

    print('')
    line()
    print('\n\t\t\t\tGrade Report')
    line()
    print('\n\t\tStudent Name  /  Numeric Average  /  Letter Grade')
    line()
    print('\n\t\t{:s}' .format(student_name) .ljust(26) + '{:.1f}%' .format(average_grade) .ljust(22) +
          '{:s}' .format(letter_grade))


def line():
    print('\t', 60 * '_')


def input_error():
    print('\n\t', 60 * '-')
    print('\t\t****Invalid input, a grade between 0 and 100****')
    print('\t', 60 * '-')


def main():

    # Declaration of variables.
    run_again = 'y'

    global total_students, total_average, test, grade

    # Main program loop.
    while run_again.lower() == 'y' or 'yes':
        test = 1
        grade = 0

        print('\n\n\t\t\t\tGrade Calculator')
        line()
        input_student_data()
        compute_average()
        determine_letter_grade()
        output_student_data()

        total_students += 1
        total_average += average_grade

        while True:
            line()
            run_again = input('\n\t\tDo you wish enter in another Student? (y/n): ')
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
            print('\n\t\tTotal students processed : ', total_students)
            school_average = total_average / total_students
            print('\t\tClass Average........... : ', format(school_average, '.1f') + '%')
            break

    print('\n\n')
    os.system("pause")

main()

