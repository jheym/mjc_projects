/*
Author: Justin Heyman
Assignment: Lab 3
Program Description: 

	Create a program that gives the user a menu of options, it should look something like this:

	Menu Options
	1. Enter your test score, I'll tell you the grade. (0-59 F, 60-69 D, 70-79 C, 80-89 B, 90-100 A, everything else is invalid)
	2. Enter your GPA to see if you made the Dean's List. (3.9 - 4.0 makes the dean's list, 0-3.8 doesn't, everything else is invalid)
	3. Exit
	Enter a choice:

	Hints:

	Use a switch statement or do while loop for the menu
	Use if/else statements or switch statement for the conditions under each option
	What to turn in:

	1. Attach the Lab3 cpp file as usual (20 points)

	2. If you can check for all input errors for each option (5 points extra credit)

	3. If you can make the menu option a loop until user chooses to exit, 10 points extra credit)


*/

#include <iostream>
using namespace std;

int main()
{
	int choice;
	float score, gpa;

	do
	{
		//Menu Prompt
		cout << "Menu Options" << endl;
		cout << "============\n";
		cout << "1. Enter the test score. I'll tell you the grade.\n";
		cout << "2. Enter your GPA to see if you made the Dean's List.\n";
		cout << "3. Exit.\n\n";	
		cout << "Enter the choice: ";
		
		//Integer type validation
		while (!(cin >> choice)) 
		{
			cout << "Please enter an integer value or '3' to exit: ";
			cin.clear(); //Clears and restores input stream.
			cin.ignore(100, '\n'); //Discards whatever input was stored into the variable up to 100 characters or until it reaches a newline char.
		}
		
		
		switch (choice)
		{
			case 1: 
				cout << "Enter the student's score: ";
				
				while (!(cin >> score)) //Validates float type
				{
					cout << "Please enter an integer value between 0 and 100: " << endl;
					cin.clear();
					cin.ignore(100, '\n');
				}
					
				if (score >= 0 && score < 60)
				{
					cout << "The student's grade is an F. \n\n";
				}
				else if (score >= 60 && score < 70)
				{
					cout << "The student's grade is a D. \n\n";
				}
				else if (score >= 70 && score < 80)
				{
					cout << "The student's grade is a C. \n\n";
				}
				else if (score >= 80 && score < 90)
				{
					cout << "The student's grade is a B. \n\n";
				}
				else if (score >= 90 && score <= 100)
				{
					cout << "The student's grade is an A. \n\n";
				}
				else
				{
					cout << "Enter a score within 0 and 100.\n";
				}
				break;
	
			case 2:
				cout << "Enter your GPA: ";
				while (!(cin >> gpa || gpa > 0 && gpa <= 4.0)) //Validates float type
				{
					cout << "Please enter a value between 0.0 and 4.0: " << endl;
					cin.clear();
					cin.ignore(100, '\n');
				}

				if (gpa >= 3.9 && gpa <= 4.0)
				{
					cout << "Congratulations you have made the dean's list. \n\n";
				}
				else if (gpa >= 0 && gpa < 3.9)
				{
					cout << "Sorry, you have not made the dean's list. \n\n";
				}
				break;

			case 3:
				//Program will exit at end of loop
				break;

			default:
				cout << "Invalid menu choice.\n\n";
		}
	
	} while (choice != 3); // If 3 is entered during Menu Prompt, compiler exits here.



	return 0; 



}