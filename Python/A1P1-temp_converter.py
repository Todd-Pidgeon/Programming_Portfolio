
# Program Name:       A1P1-temp_converter.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 28/09/2015
# Program Purpose:    Converts given temperature from Celsius to Fahrenheit.

import os

# Declare variable
celsius = 0.0

print('\n\t\tCelsius to Fahrenheit Converter')
print('-------------------------------------------------------------------\n')

# User input temperature in Celsius
while True:
    try:
        celsius = float(input('\t\tTemperature in Celsius: '))
    except ValueError:
        print('-------------------------------------------------------------------')
        print('\t\t****Please enter a number****')
        print('-------------------------------------------------------------------\n')
    else:
        break

# Compute conversion
fahrenheit = (9/5*celsius+32)

# Output converted temperature
print('\n-------------------------------------------------------------------')
print('\t\tTemperature in Fahrenheit:', format(fahrenheit, '.1f'))
print('-------------------------------------------------------------------\n')
print('\n')

os.system("pause")