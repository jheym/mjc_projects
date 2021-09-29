# -*- coding: utf-8 -*-
"""
Created on Wed Jul 21 13:24:40 2021

@author: jheym

Utilizing bisection search, calculates how much to invest in savings per month 
in order to save enough for a down payment on a $1,000,000 home in 36 months
"""

annual_salary = float(input('Enter your annual salary: '))

total_cost = 1000000.0
temp_annual_salary = annual_salary
current_savings = 0.0
portion_down_payment = 0.25
r = 0.04 #portion annual return
monthly_salary = annual_salary/12.0
semi_annual_raise = 0.07
number_of_months = 0
raise_counter = 0
savings_needed = total_cost*portion_down_payment
low = 0
high = 10000
ans = (low + high)/2
int_rate = 0
portion_saved = int_rate/10000.0
numGuesses = 0

while abs(ans - int_rate) >= 1:
    numGuesses += 1
    portion_saved = ans/10000.0
    
    while current_savings < savings_needed:
        current_savings += (current_savings*r)/12
        current_savings += (monthly_salary*portion_saved)
        number_of_months += 1
        raise_counter += 1
        if raise_counter == 6:
            temp_annual_salary += semi_annual_raise*annual_salary
            monthly_salary = temp_annual_salary/12.0
            raise_counter = 0
    if number_of_months > 36:
        low = int(portion_saved*10000)
    else:
        high = int(portion_saved*10000)
    int_rate = ans
    ans = (high + low)/2
    current_savings = 0.0
    number_of_months = 0
    raise_counter = 0
    temp_annual_salary = annual_salary
    
print('You should save ', portion_saved, 'of your monthly salary')
print('Number of guesses', numGuesses)
    
    
    
    





"""
while current_savings < savings_needed:
    current_savings += (current_savings*r)/12
    current_savings += (monthly_salary*portion_saved)
    number_of_months += 1
    raise_counter += 1
    if raise_counter == 6:
        annual_salary += semi_annual_raise*annual_salary
        monthly_salary = annual_salary/12.0
        raise_counter = 0
"""