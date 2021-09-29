#Author:Justin Heyman
#Date: 6/28/2018
#Assignment: Lab 1 Programming Basic Shapes (1/2)
#Program: Basic Shapes
#CS270 SU 3338

#What this program does:
    #Draws a parallelogram.
    #Draws a pentagon using a looping range function.
    
#Created in Python 3.7.0 with IDLE


import turtle

bert = turtle.Turtle()
screen = turtle.Screen()
screen.title("Geometry")
bert.up()
bert.width(5)
bert.speed(1)
bert.color("white")
bert.fillcolor("orange red")
screen.bgcolor("black")

def parallelogram(): #This function draws a parallelogram.
    bert.down()
    bert.begin_fill()
    bert.fd(200)
    bert.left(60)
    bert.fd(120)
    bert.left(120)
    bert.fd(200)
    bert.left(60)
    bert.fd(120)
    bert.end_fill()
    bert.up()

def pentagon():#This function draws a Pentagon.
    bert.down()
    bert.begin_fill()
    for i in range(5): #loops the following indented steps 5 times
        bert.fd(65)
        bert.left(72)
    bert.end_fill()
    bert.up()
    

bert.setpos(-300,0)
parallelogram()

bert.home()

bert.setpos(100,0)
pentagon()

bert.home()
bert.left(90)
bert.fd(500) #weeeeeeee


   
    
    
