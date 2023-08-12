//
// Created by Булат Гумеров on 18.04.2023.
//

#include "main.h"


int main()
{
    char* k = (char*)malloc(256 * sizeof(char));
    char** table = (char**)malloc(10 * sizeof(char*));
    for (int i = 0; i < 10; i++)
    {
        table[i] = NULL;
    }
    int select = 0;
    while (select != 4)
    {
        cout<<"\n1)Add\n2)Show\n3)Find\n4)Exit\n";
        cin >> select;
        if (select == 1)
        {
            char* key = (char*)malloc(256 * sizeof(char));
            cout << "Enter key-word:\n";
            cin >> key;
            int index = _hash(key);
            if (table[index] == NULL)
            {
                table[index] = (char*)malloc(sizeof(key));
                table[index] = key;
                cout<<"Element is added\n";
            }
            else
            {
                if (table[index] != NULL)
                {
                    cout<<"Element is already exsist\n";
                }
            }
        }
        else if (select == 2)
        {
            if (table != NULL)
            {
                cout<<"Hash-table:\n";
                for (int i = 0; i < 10; i++)
                {
                    if (table[i] != NULL)
                    {
                        cout << "Index:" << i << " " << "Key:" << table[i] << "\n";
                    }
                }
            }
            else
            {
                cout<<"Table is empty\n";
            }
        }
        else if (select == 3)
        {
            if (table != NULL)
            {
                cout<<"enter key for find:\n";
                cin >> k;
                int index = _hash(k);
                if (strcmp(table[index], k) == 0)
                {
                    cout << "Index:" << index << endl;
                }
                else
                {
                    cout<<"Not found\n";
                }
            }
            else
            {
                cout << "Table is empty\n";
            }
        }
        else if (select == 4)
        {
            break;
        }
    }
}