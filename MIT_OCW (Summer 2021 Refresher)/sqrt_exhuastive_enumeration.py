# -*- coding: utf-8 -*-
"""
Created on Sat Jun 26 17:08:03 2021

@author: jheym
"""

x = 123456
epsilon = 0.01
step = epsilon**3
numGuesses = 0
ans = 0.0
while abs(ans**2 - x) >= epsilon and ans*ans <= x:
    ans += step
    numGuesses += 1
print('numGuesses =', numGuesses)
if abs(ans**2 - x) >= epsilon:
    print('Failed on square root of', x)
else:
    print(ans, 'is close to square root of', x)