/***
Justin Heyman
CSCI 272-7075 Spring 2019
Assign 02
Creating a recursive function to reverse print a linked list.
*/
#include <iostream>
using namespace std;

struct nodeType
{
    int info;  /// data for node
    nodeType *link; /// link to next node (or null)
};


int main()
{
    /// declare a node

    nodeType *first, *last; /// node pointers for linked list
    nodeType *newNode; /// temp node pointer for creating nodes
    nodeType *current; /// node for traversing list

    first = nullptr; /// no node exists
    last = nullptr;  /// no node exists

    /// linked list with 17 -> -1 -> 22 -> 45 -> 7
    /// create first node
    newNode = new nodeType;
    newNode->info = 17;
    newNode->link = nullptr;
    first = newNode;
    last = newNode;

    /// create second node and add to end list
    newNode = new nodeType; /// create new node
    newNode->info = -1;     /// insert data
    newNode->link = nullptr;/// link points to null
    last->link = newNode;   /// last->link point to new node
    last = newNode;         /// last points to last node

    /// create third node and add to end of list
    newNode = new nodeType;
    newNode->info = 22;
    newNode->link = nullptr;
    last->link = newNode;
    last = newNode;

   /// create fourth node and add to end of list
    newNode = new nodeType;
    newNode->info = 45;
    newNode->link = nullptr;
    last->link = newNode;
    last = newNode;

   /// create fifth node and add to end of list
    newNode = new nodeType;
    newNode->info = 7;
    newNode->link = nullptr;
    last->link = newNode;
    last = newNode;


/// print out the list
    current = first;  /// current points to beginning of list
    cout << "This is the linked list:" << endl;
    while (current != nullptr)
    {
        cout << current->info << "->";
        current = current->link;
    }
    cout << "NULL" << endl << endl;  ///end of list

/// reverse the list
     void reverse();
     {
        // Initialize current, last and
        // first pointers
        nodeType *current = first;
        nodeType *last = nullptr, *link = nullptr;


        while (current != nullptr)
        {
            // Store link
            link = current->link;

            // Reverse current node's pointer
            current->link = last;

            // Move pointers one position ahead.
            last = current;
            current = link;
        }
        first = last;
    }

    /// print out the list in reverse
    cout << "This is the linked list in reverse:" << endl;
    current = first;  /// current points to beginning of list
    while (current != nullptr)
    {
        cout << current->info << "->";
        current = current->link;
    }
    cout << "NULL" << endl;  ///end of list

    return 0;
}/// end main
