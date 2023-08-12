//
// Created by Булат Гумеров on 28.02.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_THREE_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_THREE_H

// СПИСОК СПИСКОВ


#include <iostream>
using namespace std;

struct Sub_List {
    int value_sub;
    Sub_List* NextS;
};


struct Main_List {
    int value;
    Main_List* NextM;
    Sub_List* sub;
};

Main_List* list;

void Show(Main_List* list) {
    Main_List* temp = list;
    cout<<"\nMain list/Sub List\n";
    if (temp->NextM == NULL) {
        cout<<"List is empty\n";
    }
    while (temp->NextM != NULL) {
        temp = temp->NextM;
        cout << temp->value << ":";
        Sub_List* subl = temp->sub;
        while (subl != NULL) {
            cout<<" "<<subl->value_sub;
            subl = subl->NextS;
        }
        cout<<"\n";
    }
}

void Start(Main_List* list) {
    cout<<"\nEnter element:\n";
    int _value;
    cin>>_value;
    Main_List* temp = new Main_List;
    temp->value = _value;
    temp->NextM = NULL;
    temp->sub = NULL;
    list->NextM = temp;
    cout<<"Element added\n";
}


void After(Main_List* list) {
    if (list->NextM == NULL) {
        Start(list);
    } else {
        int _value;
        cout<<"Enter element, after which you want to add\n";
        cin >> _value;
        Main_List* temp = list->NextM;
        while (temp != NULL) {
            if (temp->value == _value) {
                int a;
                cout<<"Element: ";
                cin >> a;
                Main_List* pTemp = new Main_List;
                pTemp->value = a;
                pTemp->sub = NULL;
                pTemp->NextM = temp->NextM;
                temp->NextM = pTemp;
                cout<<"Element is added\n";
            }
            temp = temp->NextM;
        }
    }
}


void Before(Main_List* list) {
    if (list->NextM == NULL) {
        Start(list);
    } else {
        int _value;
        cout<<"\nEnter element,before which you want to add\n";
        cin >> _value;
        Main_List* last = list;
        Main_List* temp = list->NextM;
        while (temp != NULL) {
            if (temp->value == _value) {
                int a;
                cout<<"Element: ";
                cin >> a;
                Main_List* newtemp = new Main_List;
                newtemp->value = a;
                newtemp->sub = NULL;
                newtemp->NextM = temp;
                last->NextM = newtemp;
                cout<<"Element added\n";
                return;
            }
            last = last->NextM;
            temp = temp->NextM;
        }
    }
}

void pushSub(Main_List* list) {
    if (list == NULL) {
        cout << "\nMain list is empty";
        return;
    }
    int _value;
    cout<<"Enter name of main list,where you want to add\n";
    cin >> _value;
    Main_List* temp = list;
    while (temp != NULL) {
        if (temp->value == _value) {
            if (temp->sub == NULL) {
                int a;
                cout<<"Enter element:\n";
                cin >> a;
                Sub_List* subl = new Sub_List;
                subl->value_sub = a;
                subl->NextS = NULL;
                temp->sub = subl;
                return;
            }
            int whereadd;
            int _value;
            cout<<"\n1) Before\n2) After\n";
            cin >> whereadd;
            Sub_List* subl = temp->sub;
            if (whereadd == 1) {
                cout<<"\nEnter element befiore which you want to add\n";
                cin >> _value;
                cout<<"Enter element\n";
                int value_;
                cin >> value_;
                if (subl->value_sub == _value) {
                    Sub_List* sub2 = new Sub_List;
                    sub2->value_sub = value_;
                    sub2->NextS = temp->sub;
                    temp->sub = sub2;
                    return;
                }
                while (subl->NextS != NULL) {
                    if (subl->NextS->value_sub == _value) {
                        Sub_List* sub2 = new Sub_List;
                        sub2->value_sub = value_;
                        sub2->NextS = subl->NextS;
                        subl->NextS = sub2;
                        return;
                    }
                    subl = subl->NextS;
                }
            }
            else if (whereadd == 2)
            {
                cout<<"Enter element after which you want to add\n";
                cin >> _value;
                cout<<"Enter element\n";
                int value_;
                cin>>value_;
                while (subl != NULL)
                {
                    if (subl->value_sub == _value)
                    {
                        Sub_List* sub2 = new Sub_List;
                        sub2->value_sub = value_;
                        sub2->NextS = subl->NextS;
                        subl->NextS = sub2;
                        return;
                    }
                    subl = subl->NextS;
                }
            }
        }
        temp = temp->NextM;
    }
}

void pop(Main_List* list)
{
    if (list == NULL)
    {
        cout<<"List is empty.\n";
        return;
    }
    int _value;
    cout<<"Enter element which you want to delete:\n";
    cin >> _value;
    Main_List* temp = list->NextM;
    Main_List* pred = list;
    Sub_List* sub_temp;
    while (temp !=NULL) {
        if (temp->value == _value) {
            while (temp->sub != NULL) {
                sub_temp = temp->sub;
                temp->sub = temp->sub->NextS;
                delete sub_temp;
            }
            pred->NextM = temp->NextM;
            delete temp;
            break;
        }
        pred = temp;
        temp = temp->NextM;
    }
}

void popS(Main_List* list)
{
    int _value;
    int list_item;
    cout<<"Enter the main list item you want to delete.\n";
    cin >> list_item;
    Main_List* temp = list;
    while (temp != NULL)
    {
        if (temp->value == list_item)
        {
            if (temp->sub == NULL)
            {
                cout<<"List is empty\n";
                return;
            }
            cout<<"Enter element which you want to delete\n";
            cin >> _value;
            Sub_List* subl = temp->sub;
            if (subl->value_sub == _value)
            {
                Sub_List* del = temp->sub;
                temp->sub = temp->sub->NextS;
                delete del;
                return;
            }
            while (subl->NextS != NULL)
            {
                if (subl->NextS->value_sub == _value)
                {
                    Sub_List* del = subl->NextS;
                    subl->NextS = del->NextS;
                    delete del;
                    return;
                }
                subl = subl->NextS;
            }
        }
        temp = temp->NextM;
    }
}

void Search(Main_List* list)
{
    if (list == NULL)
    {
        cout<<"List is empty\n";
        return;
    }
    int _value;
    int mini_counter = 0;
    cout<<"Enter element for finding:\n";
    cin >> _value;
    Main_List* temp = list;
    while (temp != NULL)
    {
        Sub_List* subl = temp->sub;
        if (temp->value == _value)
        {
            cout<<"Find in main list\n";
            mini_counter++;
        }
        if (subl == NULL)
        {
            temp = temp->NextM;
            continue;
        }
        while (subl != NULL)
        {
            if (subl->value_sub == _value)
            {
                cout<<"Find in Sub list\n";
                mini_counter++;
            }
            subl = subl->NextS;
        }
        temp = temp->NextM;
    }
    if (mini_counter == 0)
    {
        cout<<"Element is not found.\n";
    }
}
#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_THREE_H
