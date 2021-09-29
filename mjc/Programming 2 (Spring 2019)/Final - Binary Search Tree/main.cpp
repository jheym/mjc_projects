/**
    Justin Heyman
    CSCI 272 - Spring 2019
    Final Part 1
    5/1/2019

    You will be uploading these three files into Canvas for Final Part 1
    main.cpp
    binaryTree.h
    binarySearchTree.h

    Download these files from Canvas in Final Part 1 and put them in a project in Code::Blocks.
    We will work through the functions that need to be developed.


Use this data to develop your code
65 55 22 44 61 19 90 10 78 52 -999

*/

#include <iostream>
#include "binarySearchTree.h"

using namespace std;

int main()
{
	bSearchTreeType<int>  treeRoot;

	int num;

	cout << "Enter integers ending with -999" << endl;
	cin >> num;

	while (num != -999)
	{
		treeRoot.insert(num);
		cin >> num;
	}

	cout << endl << "Tree nodes in inorder: ";
	treeRoot.inorderTraversal();
	cout << endl << "Tree nodes in preorder: ";
	treeRoot.preorderTraversal();
	cout << endl << "Tree nodes in postorder: ";
	treeRoot.postorderTraversal();
    cout << endl;


	cout << "Tree Height: " << treeRoot.treeHeight()
		 << endl;

    cout << "Number of Nodes: "
		 << treeRoot.treeNodeCount() << endl;

   	cout << "Number or Leaves: "
		 << treeRoot.treeLeavesCount() << endl;

	cout << "Number of single Parents: "
		 << treeRoot.singleParent() << endl;

	/// swap subtrees
	treeRoot.swapSubtrees();
	cout << endl;
	cout << "********* After swapping subtrees **********" << endl;
    cout << endl << "Tree nodes in inorder: ";
	treeRoot.inorderTraversal();
	cout << endl << "Tree nodes in preorder: ";
	treeRoot.preorderTraversal();
	cout << endl << "Tree nodes in postorder: ";
	treeRoot.postorderTraversal();
	cout << endl;

	cout << endl;

	return 0;
}
