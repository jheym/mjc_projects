# -*- coding: utf-8 -*-
"""
Created on Sat Jun 26 13:41:32 2021

@author: jheym
"""

tempstring = str()
pretotal = float()
total = 0
s = '1.23,2.4,3.123'
for i in s:
    if i != ',':
        tempstring = tempstring + i
        continue
    elif i == ',':
        pretotal = float(tempstring)
        tempstring = str()
        total = total + pretotal
        pretotal = float()
        continue
         
total = total + float(tempstring)
         
print(total)

        
        

