//clockType.h, the specification file for the class clockType

/*  Justin Heyman
    CSCI272
    Assign 01
    2/6/2019
*/

// Code modified by Justin Heyman
// Modified code will be marked with an asterisk (*) at the end of that line's comment.

class clockType
{
public:
    void setHours(int hours);
    void setMinutes(int minutes);
    void setSeconds(int seconds);
      //Function to set the time.
      //The time is set according to the parameters.
      //Postcondition: hr = hours; min = minutes;
      //               sec = seconds;
      //               The function checks whether the
      //               values of hours, minutes, and seconds
      //               are valid. If a value is invalid, the
      //               default value 0 is assigned.

    void getTime(int& hours, int& minutes, int& seconds) const // moved from imp file to be inline here*
{
	hours = hr;
	minutes = min;
	seconds = sec;
}


    void printHours() const; // split printTime() into three different functions: hours, minutes, and seconds.*
    void printMinutes() const;
    void printSeconds() const;

    void incrementSeconds();
      //Function to increment the time by one second.
      //Postcondition: The time is incremented by one second.
      //               If the before-increment time is
      //               23:59:59, the time is reset to 00:00:00.

    void incrementMinutes();
      //Function to increment the time by one minute.
      //Postcondition: The time is incremented by one minute.
      //               If the before-increment time is
      //               23:59:53, the time is reset to 00:00:53.

    void incrementHours();
      //Function to increment the time by one hour.
      //Postcondition: The time is incremented by one hour.
      //               If the before-increment time is
      //               23:45:53, the time is reset to 00:45:53.

    bool equalTime(const clockType& otherClock) const;
      //Function to compare the two times.
      //Postcondition: Returns true if this time is equal to
      //               otherClock; otherwise, returns false.

    int printTimeofDayInSeconds(); // prints the time of the day in seconds*

    int remainingDaySeconds(); // prints the remaining time of the day in seconds*

    clockType(int hours, int minutes, int seconds);
      //Constructor with parameters
      //The time is set according to the parameters.
      //Postcondition: hr = hours; min = minutes;
      //               sec = seconds;
      //               The constructor checks whether the
      //               values of hours, minutes, and seconds
      //               are valid. If a value is invalid, the
      //               default value 0 is assigned.


    clockType();
      //Default constructor
      //The time is set to 00:00:00.
      //Postcondition: hr = 0; min = 0; sec = 0;

private:
    int hr;  //variable to store the hours
    int min; //variable to store the minutes
    int sec; //variable to store the seconds
    int nDayTimeSeconds; //Total time in seconds*
    int nDayTimeLeftSeconds; //Total time left in seconds*
};
