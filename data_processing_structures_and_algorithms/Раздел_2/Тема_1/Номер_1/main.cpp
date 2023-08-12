//
// Created by Булат Гумеров on 18.04.2023.
//
#include "main.h"


int main() {
    createarray();
    show(a);
    int choice;
    while (true)
    {
        cout << "\nchoice your command:";
        cout << "\n1. Bubble sort";
        cout << "\n2. Insert sort";
        cout << "\n3. Choice sort";
        cout << "\n4. Rearm array";
        cout << "\n0. Exit";
        cin >> choice;
        if (choice == 1) { show(a); buble_sort(); }
        else if (choice == 2) { show(a); inser_sort(); }
        else if (choice == 3) { show(a); choice_sort(); }
        else if (choice == 4)createarray();
        else if (choice == 0) break;
        else cout << "\nerror.Try again";
    }
    return 0;
}


