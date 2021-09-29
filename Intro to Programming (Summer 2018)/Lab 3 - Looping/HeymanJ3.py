#Author: Justin Heyman
#Date: 7/21/2018
#Assignment: Lab 3, Looping Program
#CS270 SU 3338
#Program Description:
""" Takes a student name and computes an average grade based on score per assignment entered.
    'Undo' will erase the last grade entered and ask for the assignment's grade again. If user
    inputs no entry, they will be prompted to navigate various options by typing 'Y' or 'N' until
    all students' grades are complete. When finished, a list of students' average grades will print.
"""

#Lists
total = []
studentGrades = []

#Methods
def is_number(s): #Checks if input is a float or not
    try:
        float(s)
        return True
    except ValueError:
        return False

#Main Program
while True:
        
    assgn = 1 #Assignment Number (Accumulates per entry
    print("Enter the student's score per assignment. When finished, press enter.")
    print('Type "undo" to remove the last grade entered.')
    studentName = input("Please enter student's name: ")

    while studentName: #While studentName is True, loop continues
    
        score = input("{} assignment {}: ".format(studentName, assgn)).lower()
        if score == 'undo':
            if len(total) == 0:
                print('There is nothing to undo!')
            else:
                total.pop(-1) #Removes the last item on the list
                assgn -= 1 #Diminisher
                print(total)
                
        elif score == '':
            done = input("Are you done entering grades for {}? [Y/N]: ".format(studentName)).lower()
            if done == 'y' and len(total) > 0: 
                average = round(sum(total) / len(total), 1) #Sums the list, divides by length of list, rounds to 10th
                studentGrades.append((studentName, average)) #Stores student's grade in new list
                print("The average score for {} is {}.".format(studentName, average))
                studentName = False
            elif len(total) == 0:
                print("There are no grades to compute.")
                studentName = False
        
        elif is_number(score):
            total.append(float(score)) #Adds entry to list
            assgn += 1 #Accumulator
            print(total)
        
        else:
            print("Entry must be an integer or decimal.")

    viewgrades = input("Would you like to see the current student Grades? [Y/N]: ").lower()
    if viewgrades == 'y':
        if len(studentGrades) == 0:
            print("There are currently no grades entered.")
        else:
            print(studentGrades)

    newStudent = input("Would you like to enter grades for another student? [Y/N]: ").lower()   
    if newStudent == 'y' or newStudent == 'n':
        if newStudent == 'y':
            total.clear()
            continue
        elif newStudent == 'n':
            exit = input("Are you finished entering grades? [Y/N]: ").lower()
            if exit == 'y':
                print("Here are the final grades for your students: {}".format(studentGrades))
                break
            else:
                continue
 
                    
                
            
      

