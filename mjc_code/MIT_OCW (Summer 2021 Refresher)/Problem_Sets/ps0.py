# -*- coding: utf-8 -*-
"""
Created on Sat Jul 17 12:47:35 2021

@author: jheym
"""

"""
Asks the user to enter a number "x"
Asks the user to enter a number "y"
Prints out the number "x", raised to the power "y"
Prints out the log (base 2) of x
"""

import numpy

x = 0
y = 0
x = int(input('Enter a number: '))
y = int(input('Enter a number: '))
print('x**y =', x**y)
print('log(x) =', numpy.log2(x))
