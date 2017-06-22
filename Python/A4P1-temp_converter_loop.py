
# Program Name:       A4P1-temp_converter_loop.py
# Programmer Name:    Todd Pidgeon
# Date Last Compiled: 29/10/2015
# Program Purpose:    Converts temperatures 0 - 20 from Celsius to Fahrenheit.

import os

# Visual display.
print('\n\t----------------------------------------------')
print('\t\tCelsius to Fahrenheit Converter')
print('\t----------------------------------------------')
print('\t\tCelsius\t /  Fahrenheit')
print('\t----------------------------------------------\n')

# Compute conversion and repeat for 0 - 20 degrees Celsius
for celsius in range(0, 21):
    fahrenheit = (9/5*celsius+32)
    print('\t\t %4.1f C   =   %4.1f F' % (celsius, fahrenheit))

print('')
os.system("pause")
