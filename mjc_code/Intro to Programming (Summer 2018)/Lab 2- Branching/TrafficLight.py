#Author:Justin Heyman
#Date: 7/15/2018
#Assignment: Lab 2 Branching (2/2)
#Program: Traffic Light
#CS270 SU 3338

#What this program does:
    # Allows user to choose between drawing 3 light colors.
    
    
#Created in IDLE (Python 3.7)

print('''This is the stoplight command center. You may enter one of three 
      colors, or you can exit at any time by typing "Exit".''')

while True:
    ans = input('Type red, green, or yellow: ').lower()

    if ans == 'green' or ans == 'g':
        print("Go")
    elif ans == 'red' or ans == 'r':
        print("Stop")
    elif ans == 'yellow' or ans == 'y':
        print("Slow")
    elif ans == 'exit':
        print("Goodbye!")
        break
    else:
        print('''Standard traffic lights are either green, red, or yellow.
Please enter a valid color.''')
    
        



