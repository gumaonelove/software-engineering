//
// Created by Булат Гумеров on 18.04.2023.
//

#include "main.h"


int main() {
    int size;
    cout << "\nEnter array size:";
    cin >> size;
    create(size);
    cout << "\nArray:";
    for (int i = 0; i < size; i++)
    {
        cout << a[i] << " ";
    }
    int select = 0;
    while (select != 5) {
        cout << "\nChoice command:\n1)Shell sort\n2)Quick sort\n3)Pyramid sort\n4)Rearm array\n5)Exit\n";
        cin >> select;
        if (select == 1)
        {
            Shell(a, size);
        }
        else if (select == 2) {
            unsigned long changes = 0, compares = 0;
            int* m = (int*)malloc(size * sizeof(int));
            memcpy(m, a, size * sizeof(int));
            quicksort(m,0,size-1,changes,compares);
            for (int i = 0; i < size; i++)
            {
                cout << m[i]<<" ";
            }
            cout << "\nNumber of chages:" << changes << "\nNumber of compares:" << compares;
        }
        else if(select ==3)
        {
            pyramid_sort(size);
        }
        else if (select == 4) {
            create(size);
        }
    }
}