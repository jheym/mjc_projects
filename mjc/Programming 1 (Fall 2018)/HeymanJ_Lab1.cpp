#include <iostream>
using namespace std;

int main()
{

	double length, width, area, perimeter;
	cout << "This program takes length and width of a rectangle\n"
		<< "and computes the area of the perimeter.\n\n";


	cout << "Enter the length of the rectangle: ";
	cin >> length; 
	
	cout << "Enter the width of the rectangle: ";
	cin >> width;
	cout << "\n\n";

	perimeter = (length + width) * 2;
	area = length * width;

	cout << "The perimeter of the rectangle is " << perimeter << "." << endl << endl;
	cout << "The area of the rectangle is " << area << "." << endl << endl;
	return 0;
}