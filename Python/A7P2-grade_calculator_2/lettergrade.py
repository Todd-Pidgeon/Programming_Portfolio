
# Program Name:       lettergrade.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 23/11/2015
# Program Purpose:    Determines the letter grade of students for the Grade Calculator program


def determine_letter_grade(average_grade):

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

    return letter_grade
