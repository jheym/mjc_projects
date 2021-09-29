/*

Author: Justin Heyman
Assignment: Lab 2
Class: 5865

Program description: Takes user input for name, gpa, and scholarship and outputs the information in columns.

*/


#include <iostream>                                     
#include <string>                                       
#include <iomanip>                                      
   
using namespace std;                                    

int main()                                              
{                                                       
    string name;                            
    double gpa = 0.00;                                  
    float scholarship = 0; 

	cout << "Please enter first name: ";
	cin >> name;
	cout << endl;

	cout << "Please enter GPA: ";
	cin >> gpa;
	cout << endl;

	cout << "Please enter scholarship amount: $";
	cin >> scholarship;
	cout << endl;


    cout << fixed << setprecision(2);      

    cout << left;                                       

    cout << setw(12) << name << setw(12) << gpa
         << setw(12) << scholarship <<  endl;             

    cout << setfill('*');                               
    cout << setw(12) << name << setw(12) << gpa
         << setw(12) << scholarship << endl;             

    cout << setfill('#') << setw(12) << name
         << setw(12) << gpa
         << setw(12) << scholarship << endl;             

    cout << setfill('@') << setw (12) << name
         << setw(12) << setfill('#') << gpa
         << setw(12) << setfill('^') << scholarship
         << endl;                                       

    cout << right;                                      
    cout << setfill(' ');                               
    cout << setw(12) << name << setw(12) << gpa
         << setw(12) << scholarship << endl;             

    return 0;                                           
}                                                       