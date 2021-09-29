//Implementation File for the class clockType

/*  Justin Heyman
    CSCI272
    Assign 01
    2/6/2019
*/


// Code modified by Justin Heyman
// Modified code will be marked with an asterisk (*) at the end of that line's comment.

#include <iostream>
#include "clockType.h"

using namespace std;

void clockType::setHours(int hours)
{
	if (0 <= hours && hours < 24)
	    hr = hours;
	else
	    hr = 0;
}

void clockType::setMinutes(int minutes)
{
    if (0 <= minutes && minutes < 60)
	    min = minutes;
	else
	    min = 0;
}

void clockType::setSeconds(int seconds)
{
   if (0 <= seconds && seconds < 60)
	    sec = seconds;
	else
	    sec = 0;
}

void clockType::incrementHours()
{
	hr++;
	if(hr > 23)
 	   hr = 0;
}

void clockType::incrementMinutes()
{
	min++;
	if (min > 59)
	{
	    min = 0;
	    incrementHours();
	}
}

void clockType::incrementSeconds()
{
	sec++;

	if (sec > 59)
	{
	    sec = 0;
	    incrementMinutes();
	}
}

void clockType::printHours() const //split printTime into three different functions: hours, minutes, and seconds.*
{
	if (hr < 10)
	    cout << "0";
	cout << hr << " hours, ";
}

void clockType::printMinutes() const
{
    if (min < 10)
	    cout << "0";
	cout << min << " minutes, ";
}

void clockType::printSeconds() const
{

	if (sec < 10)
	   cout << "0";
	cout << sec << " seconds. ";
}

bool clockType::equalTime(const clockType& otherClock) const
{
	return (hr == otherClock.hr
		    && min == otherClock.min
		    && sec == otherClock.sec);
}

int clockType::printTimeofDayInSeconds() //Prints out the total time in seconds*
{
    nDayTimeSeconds = (hr * 3600) + (min * 60) + sec;
    return nDayTimeSeconds;
}

int clockType::remainingDaySeconds() //Prints out the remaining time in seconds*
{
    nDayTimeLeftSeconds = (24 * 3600) - nDayTimeSeconds;
    return nDayTimeLeftSeconds;
}

clockType::clockType(int hours, int minutes, int seconds)
{
    if (0 <= hours && hours < 24)
        hr = hours;
    else
        hr = 0;

    if (0 <= minutes && minutes < 60)
        min = minutes;
    else
        min = 0;

    if (0 <= seconds && seconds < 60)
        sec = seconds;
    else
        sec = 0;
}

clockType::clockType()  //default constructor
{
    hr = 0;
    min = 0;
    sec = 0;
}
