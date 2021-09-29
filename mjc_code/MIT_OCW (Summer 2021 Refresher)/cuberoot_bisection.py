# -*- coding: utf-8 -*-
"""
Created on Sun Jun 27 12:26:07 2021

@author: jheym
"""

x = 125
epsilon = 0.01
numGuesses = 0
low = min(x, 1.0)
high = max(1.0, x)
ans = (high + low)/2.0
while abs(ans**3 - x) >= epsilon:
    print('low =', low, 'high =', high, 'ans =', ans)
    numGuesses += 1
    if ans**3 < x:
        low = ans
    else:
        high = ans
    ans = (high + low)/2.0
print('numGuesses =', numGuesses)
print(ans, 'is close to the cubed root of', x)