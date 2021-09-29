#include <iostream>
#include <cstdio>
using namespace std;

int main()
{

int a, b;
    cout << "Integer 1: "; cin >> a; cout << endl;
    cout << "Integer 2: "; cin >> b; cout << endl;

    string ans;

    for (int n = a; n <= b; ++n)
    {
        if (n == 1)
            ans = "one";
        else if (n == 2)
            ans = "two";
        else if (n == 3)
            ans = "three";
        else if (n == 4)
            ans = "four";
        else if (n == 5)
            ans = "five";
        else if (n == 6)
            ans = "six";
        else if (n == 7)
            ans = "seven";
        else if (n == 8)
            ans = "eight";
        else if (n == 9)
            ans = "nine";
        else if (n == 0)
            ans = "Zero";
        else if (n > 9 && n%2 == 0)
            ans = "even";
        else
            ans = "odd";

        cout << ans << endl;
    }

    return 0;
};

