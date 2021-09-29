#Author:Justin Heyman
#Date: 7/13/2018
#Assignment: Lab 2 Branching (1/2)
#Program: Pick A Shape
#CS270 SU 3338

#What this program does:
    # Allows user to choose between drawing 3 shapes
    
    
#Created in IDLE (Python 3.7)

#===================================================================================================#
############################################ Parameters #############################################

import turtle
import time

bert = turtle.Turtle()
screen = turtle.Screen()
screen.title("The Shape Drawing Machine")

#Turtle Parameters
def parameters():
    bert.up()
    bert.width(5)
    bert.speed(1)
    bert.color("white")
    bert.fillcolor("orange red")
    screen.bgcolor("black")

#===================================================================================================#
######################################### Shape methods #############################################

def rectangle():
    bert.setpos(-100, 120)
    bert.down()
    bert.begin_fill()
    bert.setheading(0)
    bert.fd(200)
    bert.left(90)
    bert.fd(120)
    bert.left(90)
    bert.fd(200)
    bert.left(90)
    bert.fd(120)
    bert.end_fill()
    bert.up()

def parallelogram():
    bert.setpos(-300, -200)
    bert.down()
    bert.begin_fill()
    bert.setheading(0)
    bert.fd(200)
    bert.left(60)
    bert.fd(120)
    bert.left(120)
    bert.fd(200)
    bert.left(60)
    bert.fd(120)
    bert.end_fill()
    bert.up()
    
def pentagon():
    bert.setpos(200, -200)
    bert.down()
    bert.begin_fill()
    bert.setheading(0)
    for i in range(5): #loops the following indented steps 5 times
        bert.fd(120)
        bert.left(72)
    bert.end_fill()
    bert.up()

def selfDestruct():
    bert.reset()
    print("ERROR: SELF DESTRUCTING IN 10 SECONDS")
    time.sleep(1)
    print("9")
    time.sleep(1)
    print("8")
    time.sleep(1)
    print("7")
    time.sleep(1)
    print("6")
    time.sleep(1)
    print("5")
    time.sleep(1)
    print("4")
    time.sleep(1)
    print("3")
    time.sleep(1)
    print("2")
    time.sleep(1)
    print("1")
    time.sleep(1)
    screen.bgcolor("red")
    bert.write("You picked the wrong number.",font=("Arial", 24, "normal"), align="center")

#===================================================================================================#
############################################ The logic ##############################################

while True:
    parameters()
    print("Welcome to the shape drawing machine!")
    input("Press enter to start: ")
    print('''Instructions: Type in a numeral from 1-3 to create the corresponding shape.
[1]Rectangle, [2]Pentagon, [3]Parallelogram''')
    
    
    pick = [1,2,3] # Defines a list of 3 integers
    picked = []

    while pick: #loops as long as pick is true, when the list is empty [], pick will become false.

        ans = input("Pick a shape {}: ".format(pick))
        if ans in ("1", "2", "3"): #keeps shell from crashing if input is not an integer.
            ans = int(ans) 
            
        if ans in pick: # If user input is in the list [1,2,3]
            pick.remove(ans) # Removes the user's input from the list   
            picked.append(ans)                                              
            if ans == 1:                         ############################                 
                print("Drawing rectangle...")                             ###  
                rectangle()                                               ###  
            elif ans == 2:                                                ###  
                print("Drawing pentagon...")                              ### Here's the only part
                pentagon()                                                ### you care about grading.
            elif ans == 3:                                                ###
                print("Drawing parallelogram...")                         ###
                parallelogram()                   ###########################                        
        else:
            if ans in picked:
                print("You already drew that shape.")
            elif ans == '/0':
                selfDestruct()
                pick.clear()
                continue
            else:
                print("Try entering a number between 1 and 3.")
        continue #returns to top of while loop while pick is still true (not empty).
    else:
        print("That's all of the shapes!")
        restart = input("Would you like to restart the program? [Y/N]: ")
        if restart == 'Y' or restart == 'y':
            bert.clear()
            print("Restarting...")
            continue
        elif restart == 'N' or restart == 'n':
            print("Goodbye!")
            screen.bye()
            break
       
