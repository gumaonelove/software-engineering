//
// Created by Булат Гумеров on 18.04.2023.
//

#include "main.h"


int main()
{
    int size;
    cout << "\nEnter number of elements: ";
    cin >> size;
    int* a = (int*)malloc(size * sizeof(int));
    int select = 0;
    while (select != 5)
    {
        cout << "\nChoice command:\n1)Pocket sort with sub array\n2)Pocket sort\n3)Generic pocket sort\n4)Radix sort\n5)Exit\n";
        cin >> select;
        if (select == 1)
        {
            int i = 0;
            int sup;
            while (i < size)
            {
                sup = rand() % size;
                for (int j = i; j >= 0; j--)
                {
                    if (a[j] == sup)
                    {
                        break;
                    }
                    else if (j == 0)
                    {
                        a[i] = sup;
                        i++;
                    }
                }
            }
            printf("\nArray:\n");
            show(a, size);
            PocketSortWithArray(a, size);
        }
        else if (select == 2) {
            int i = 0;
            int sup;
            while (i < size)
            {
                sup = rand() % size;
                for (int j = i; j >= 0; j--)
                {
                    if (a[j] == sup)
                    {
                        break;
                    }
                    else if (j == 0)
                    {
                        a[i] = sup;
                        i++;
                    }
                }
            }
            printf("\nArray:\n");
            show(a, size);
            PocketsortWithoutArray(a, size);
        }
        else if (select == 3) {
            printf("\nArray:\n");
            for (int i = 0; i < size; i++)
            {
                a[i] = rand() % size;
                cout << a[i] << " ";
            }
            PocketSort(a, size);
        }
        else if (select == 4) {
            printf("\nArray:\n");
            for (int i = 0; i < size; i++)
            {
                a[i] = rand() % 900 +100;
                cout << a[i] << " ";
            }
            RadixSort(a, size);
        }
        else if (select == 5)
        {
            break;
        }
    }
}

