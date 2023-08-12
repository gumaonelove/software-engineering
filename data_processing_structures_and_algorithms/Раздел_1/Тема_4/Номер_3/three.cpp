//
// Created by Булат Гумеров on 28.02.2023.
//


#include "three.h"


int main()
{
    list = new Main_List;
    list->NextM = NULL;
    list->sub = NULL;
    int select = 0;
    while (select != 7)
    {
        cout<<"1) Add element to main list\n2) Add element to sub list\n3) pop element from main list\n4) pop element from sub list\n5) Find \n6) Show\n7) Exit\n";
        cin >> select;
        if (select == 1) {
            int _value;
            cout<<"1) Add before\n2) Add after\n";
            cin >> _value;
            if (_value == 1) {
                Before(list);
            } else if (_value == 2) {
                After(list);
            }
        } else if (select == 2) {
            pushSub(list);
        } else if (select == 3) {
            pop(list);
        } else if (select == 4) {
            popS(list);
        } else if (select == 5) {
            Search(list);
        } else if (select == 6) {
            Show(list);
        } else if (select == 7) {
            break;
        }
    }
}