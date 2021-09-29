# -*- coding: utf-8 -*-
"""
Created on Wed Jul 21 13:24:40 2021

@author: jheym

Calculates how many months it will take to save for a down payment
Every 6 months salary is raised by a percentage increase
"""

annual_salary = float(input('Enter your annual salary: '))
portion_saved = float(input('Enter the percent of your salary to save, as a decimal: '))
total_cost = float(input('Enter the cost of your dream home: '))
semi_annual_raise = float(input('Enter the semi-annual raise, as a decimal: '))

current_savings = 0.0
portion_down_payment = 0.25
r = 0.04 #portion annual return
monthly_salary = annual_salary/12.0
number_of_months = 0
raise_counter = 0
savings_needed = total_cost*portion_down_payment



while current_savings < savings_needed:
    current_savings += (current_savings*r)/12
    current_savings += (monthly_salary*portion_saved)
    number_of_months += 1
    raise_counter += 1
    if raise_counter == 6:
        annual_salary += semi_annual_raise*annual_salary
        monthly_salary = annual_salary/12.0
        raise_counter = 0

print('Number of months:', number_of_months)

