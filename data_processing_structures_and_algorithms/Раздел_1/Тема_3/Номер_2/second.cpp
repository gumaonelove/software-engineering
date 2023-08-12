//
// Created by Булат Гумеров on 27.02.2023.
//

#include "second.h"


void menu() {
    int number;
    string value;
    while (true) {
        cout << "\nChoice your command\n";
        cout << "\n1.Show list";
        cout << "\n2.Is List empty?";
        cout << "\n3.Is List full?";
        cout << "\n4.Add element";
        cout << "\n5.Delete element";
        cout << "\n6.Find element";
        cout << "\n7.Clear List";
        cout << "\n8.Exit";
        cout << "\nNumber of command:\n";
        number = failure();
        if (number == 1) {
            Show();
        } else if (number == 2) {
            if (isEmpty() == 1)cout << "\nList is empty";
            else cout << "\nList is not empty";
        } else if (number == 3) {
            if (isFull() == 1)cout << "\nList is full";
            else cout << "\nList is not full";
        } else if (number == 4) {
            push();
        } else if (number == 5) {
            pop();
        } else if (number == 6) {
            find();
        } else if (number == 7) {
            clear();
        } else if (number == 8) {
            clear();
            break;
        } else {
            cout << "\nError. Choice right command";
        }
    }
}



int main() {
    initList();
    menu();
    return 0;
}