/*
Author: Justin Heyman
Assignment: Lab 5
Program Description:
	
	Create a centimeters to inches and inches to centimeters converter. Ask the user to choose which option they want to go with or exit the menu, 
	then ask for the number of inches or centimeters to be converted, then calculate the conversion and print out the results.

	Use a do while loop for the menu, create a separate function for each choice (centimeters to inches and inches to centimeters). 
	Put those two functions in a header file that you include in your assignment. (the only function in your cpp file should be the main function). 
	Attach both files as part of your assignment.

	Extra Credit: 5 points

	Use a counter to add the number of times a user goes through the menu before deciding to exit, pass that counter as a reference parameter 
	into each menu option that is function call, then tell the user how many times they went through menu when they choose to exit.

	Extra Credit: 5 points

	Check for input errors within each option and ask for input again.


*/

#include <iostream>
#include "conversions.h"

using namespace std;


int main()
{

int choice;
float in, cm;

do
{
	//Menu Prompt
	cout << "Menu Options" << endl;
	cout << "============\n";
	cout << "1. To convert centimeters to inches, press 1.\n";
	cout << "2. To convert inches to centimeters, press 2.\n";
	cout << "3. Press 3 to exit.\n\n";
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
		cout << "Enter inches: ";

		while (!(cin >> in)) //Validates float type
		{
			cout << "Please enter an integer or decimal value: " << endl;
			cin.clear();
			cin.ignore(100, '\n');
		}
		
		cout << in << " inches equates to "; 
		inchesToCentimeters(in); 
		cout << " centimeters.\n\n";
		
		break;

	case 2:
		cout << "Enter centimeters: ";
		while (!(cin >> cm)) //Validates float type
		{
			cout << "Please enter an integer or decimal value: " << endl;
			cin.clear();
			cin.ignore(100, '\n');
		}

		cout << cm << " centimeters equates to ";
		centimetersToInches(cm);
		cout << " inches.\n\n";
	
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
