# -*- coding: utf-8 -*-
"""
Created on Wed Jul 21 13:24:40 2021

@author: jheym

Calculates how many months it will take to save for a down payment
"""

annual_salary = float(input('Enter your annual salary: '))
portion_saved = float(input('Enter the percent of your salary to save, as a decimal: '))
total_cost = float(input('Enter the cost of your dream home: '))

current_savings = 0.0
portion_down_payment = 0.25
r = 0.04 #portion annual return
monthly_salary = annual_salary/12.0
number_of_months = 0
savings_needed = total_cost*portion_down_payment



while current_savings < savings_needed:
    current_savings += (current_savings*r)/12
    current_savings += (monthly_salary*portion_saved)
    number_of_months += 1

print('Number of months:', number_of_months)

