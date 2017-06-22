
# Program Name:       A7P2-grade_calculator_2.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 23/11/2015
# Program Purpose:    Determines the numeric average and letter grade for students based on the  data input.

import os
import lettergrade

total_students = 0


def input_student_data():

    test = 1
    grade_1 = 0.0
    grade_2 = 0.0
    grade_3 = 0.0
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

    return student_name, grade_1, grade_2, grade_3


def calculate_average(grade_1, grade_2, grade_3, total_average):
    global total_students

    average_grade = (grade_1 + grade_2 + grade_3) / 3
    total_average += average_grade
    total_students += 1

    return average_grade, total_average


def output_final_grade(student_name, average_grade, letter_grade):

    line()
    print("\n\n")
    print("{a:10s} {b:^42s}" .format(a="", b="Grade Report"))
    line()
    print("{a:10s} {b:<15s} {c:5s} {d:>10s} {e:5s} {f:>10s}" .format(a="", b="Student Name", c="", d="Numeric Average",
                                                                     e='', f='Letter Grade'))
    line()
    print("{a:10s} {b:<15s} {c:5s} {d:>10.1f}% {e:5s} {f:>10s}" .format(a="", b=student_name, c="", d=average_grade,
                                                                        e='', f=letter_grade))


def line():
    print('\t', 60 * '_')


def input_error():
    print('\n\t', 60 * '-')
    print('\t\t****Invalid input, a grade between 0 and 100****')
    print('\t', 60 * '-')


def calculate_class_average(total_average):

    school_average = total_average / total_students

    return school_average


def output_report_footers(school_average):
    print('')
    line()
    print('\n\t\tTotal students processed : ', total_students)
    print('\t\tClass Average........... : ', format(school_average, '.1f') + '%')


def main():

    # Declaration of variables.
    run_again = 'y'
    total_average = 0.0

    # Main program loop.
    while run_again.lower() == 'y' or 'yes':

        print('\n\n\t\t\t\tGrade Calculator')
        line()

        student_name, grade_1, grade_2, grade_3 = input_student_data()
        average_grade, total_average = calculate_average(grade_1, grade_2, grade_3, total_average)
        letter_grade = lettergrade.determine_letter_grade(average_grade)
        output_final_grade(student_name, average_grade, letter_grade)

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
            school_average = calculate_class_average(total_average)
            output_report_footers(school_average)
            break

    print('\n\n')
    os.system("pause")

main()
