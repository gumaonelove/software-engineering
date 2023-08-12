//
// Created by Булат Гумеров on 28.02.2023.
//


#include "three.h"

void menu()
{
    int number;
    string _value;
    while (true) {
        cout << "\nEnter command:";
        cout << "\n1.Show list";
        cout << "\n2.Empty or not?";
        cout << "\n3.Full or not?";
        cout << "\n4.Add element";
        cout << "\n5.Delete element";
        cout << "\n6.Find element";
        cout << "\n7.Clear list ";
        cout << "\n0.Exit";
        number = failure();
        if (number == 1) Show();
        else if (number == 2) {
            if (isEmpty() == 1) cout << "List is empty";
            else cout << "List is not empty";
        }
        else if (number == 3) {
            if (isFull() == 1) cout << "List is full";
            else cout << "List is not full";
        }
        else if (number == 4) push();
        else if (number == 5) pop();
        else if (number == 6) find();
        else if (number == 7) Clear();
        else if (number == 0) break;
        else cout << "Error. Try again";
    }
}




int main()
{
    initList();
    menu();
    return 0;
}