# -*- coding: utf-8 -*-
"""

float + string is a TypeError

0 + 1.423.42 is a SyntaxError

castFloat = float('a') is a ValueError
    
"""


"""def sumDigits(s):
    Assumes s is a string
       Returns the sum of the decimal digits in s
           For example, if s is 'a2b3c' it returns 5"""

s = 'a2.1b.3cd.e0f1.0' # sumTotal should be 3.4


def sumDigits(s):
    tempNum = '0'
    sumTotal = 0.0
    try:
        for i in s:
            if i == '.':
                tempNum = tempNum + i
            try:
                checkFloat = float(i)
                tempNum = tempNum + i
            except ValueError:
                if i == '.':
                    continue
                tempNum = float(tempNum)
                sumTotal = sumTotal + tempNum
                tempNum = '0'
    
        if tempNum != '0':
            tempNum = float(tempNum)
            sumTotal = sumTotal + tempNum
        print('The sum of all decimal digits is', sumTotal)
    
    except ValueError:
        print('There was a Value Error. This is probably due to too many decimal points in one section.')
    
    


s = input('Enter string: ')            
sumDigits(s)


        
            
            
            
            
    







    
    

    
    
        
            
            

