# -*- coding: utf-8 -*-
"""
Spyder Editor

This is a temporary script file.
"""


def greatest_odd(x,y,z):
    while x+y+z != 0:
        if x >= y and x >= z:
            if x%2 != 0:
                print(x)
                break
            else:
                x=0
        elif y >= x and y >= z:
            if y%2 != 0:
                print(y)
                break
            else:
                y=0
        elif z >= x and z >= y:
            if z%2 != 0:
                print(z)
                break
            else:
                z=0
    if x+y+z == 0:
        print("There are no odd numbers.")
    else: 
        return   

greatest_odd(10,1,9)
        
            
            

