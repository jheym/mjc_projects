#include <iostream>
#include <cstddef>

using namespace std;

class Node{
    public:
        int data;
        Node *left;
        Node *right;
        Node(int d){
            data = d;
            left = nullptr;
            right = nullptr;
        }
};
class Solution{
    public:
  		Node* insert(Node* root, int data) {
            if(root == nullptr) {
                return new Node(data);
            }
            else {
                Node* cur;
                if(data <= root->data){
                    cur = insert(root->left, data);
                    root->left = cur;
                }
                else{
                    cur = insert(root->right, data);
                    root->right = cur;
               }

               return root;
           }
        }

    int getHeight(Node* root){
  //Write your code here
 if(root->left==nullptr && root->right==nullptr)
    {
        return 0;
    }
    else if(root->left ==nullptr)
    {
         int heightR=getHeight(root->right);
         return 1+heightR;
    }
    else if(root->right == nullptr)
        {
         int heightL = getHeight(root->left);
          return 1 + heightL;
        }

    int heightL = getHeight(root->left);
    int heightR = getHeight(root->right);

    if(heightL > heightR)
    {

        return 1 + heightL;
    }
    else
    {
        return 1 + heightR;
    }
		}

}; //End of Solution

int main() {
    Solution myTree;
    Node* root = nullptr;
    int t;
    int data;

    cin >> t;

    while(t-- > 0){
        cin >> data;
        root = myTree.insert(root, data);
    }
    int height = myTree.getHeight(root);
    cout << height;

    return 0;
}



