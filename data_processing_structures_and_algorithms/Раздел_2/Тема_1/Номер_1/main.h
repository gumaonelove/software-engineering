//
// Created by Булат Гумеров on 18.04.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_MAIN_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_MAIN_H


#include <iostream>

using namespace std;

int* a = NULL;
int compares, changes = 0;
int sizea = 0;

void show(int *b) {
    cout << "\nArray: ";
    for (int i = 0; i < sizea; i++)
    {
        cout << b[i] << " ";
    }
    cout << "\n";
}

int* copy_of_a() {
    int* b = new int[sizea];
    for (int i = 0; i < sizea; i++)
    {
        b[i] = a[i];
    }
    return b;
}

void createarray() {
    sizea = 0;
    cout << "\nEnter number of elements: \n";
    cin >> sizea;
    if (a != NULL) delete[] a;
    a = new int[sizea];
    srand(static_cast<unsigned int>(time(0)));
    for (int i = 0; i < sizea; i++)
    {
        a[i] = rand() % 100;
    }
    cout << "Massive is create";
}

void buble_sort() {
    /*обходим массив от начала до конца, попутно меняя местами неотсортированные соседние элементы.
    В результате первого прохода на последнее место «всплывёт» максимальный элемент.
    Теперь снова обходим неотсортированную часть массива (от первого элемента до предпоследнего)
    и меняем по пути неотсортированных соседей. Второй по величине элемент окажется на предпоследнем месте.
    Продолжая в том же духе, будем обходить всё уменьшающуюся неотсортированную часть массива,
    запихивая найденные максимумы в конец.*/
    compares = 0; changes = 0;
    int* b = copy_of_a();
    int temp;
    for (int i = 0; i < sizea; i++)
    {
        for (int j  = sizea-1; j>i ; j--)
        {
            compares++;
            if (b[j - 1] > b[j]) {
                temp = b[j - 1];
                b[j - 1] = b[j];
                b[j] = temp;
                changes++;
            }
        }
    }
    cout << "\nArray is sorted";
    show(b);
    cout << "\nNumber of compares: " << compares;
    cout << "\nNumber of changes: " << changes;
    delete[]b;
}

void inser_sort() {
    /*Проходим по массиву слева направо и обрабатываем по очереди каждый элемент.
    Слева от очередного элемента наращиваем отсортированную часть массива,
    справа по мере процесса потихоньку испаряется неотсортированная.
    В отсортированной части массива ищется точка вставки для очередного элемента. */
    //Сам элемент отправляется в буфер, в результате чего в массиве появляется свободная ячейка —
    //это позволяет сдвинуть элементы и освободить точку вставки.
    compares = 0; changes = 0;
    int* b = copy_of_a();
    for (int i = 1; i < sizea; i++)
    {
        int j = i - 1;
        while ((++compares) && j >= 0 && b[i] < b[j])
        {
            j = j - 1;
        }
        if (j + 1 != i)
        {
            int temporary = b[i]; int l = i - 1; changes++;
            while (l >= j + 1)
            {
                b[l + 1] = b[l]; l--;
                changes++;
            }
            b[j + 1] = temporary; changes++;
        }

    }
    changes = changes / 3;
    cout << "\nArray is sorted";
    show(b);
    cout << "\nNumber of compares: " << compares;
    cout << "\nNumber of changes: " << changes;
    delete[]b;
}

void choice_sort() {
    /*проходим по массиву в поисках максимального элемента.
    Найденный максимум меняем местами с последним элементом.
    Неотсортированная часть массива уменьшилась на один элемент (не включает последний элемент, куда мы переставили найденный максимум).
    К этой неотсортированной части применяем те же действия — находим максимум и ставим его на последнее место в неотсортированной части массива.
    И так продолжаем до тех пор, пока неотсортированная часть массива не уменьшится до одного элемента.*/
    compares = 0; changes = 0;
    int* b = copy_of_a();
    int min = 0;
    int temp = 0;
    for (int i = 0; i < sizea - 1; i++)
    {
        min = i;
        for (int j = i + 1; j < sizea; j++)
        {
            compares++;
            if (b[j] < b[min])
            {
                min = j;
            }
        }
        if (i != min)
        {
            temp = b[i];
            b[i] = b[min];
            b[min] = temp;
            changes++;
        }
    }
    cout << "\nArray is sorted";
    show(b);
    cout << "\nNumber of compares: " << compares;
    cout << "\nNumber of changes: " << changes;
    delete[]b;
}


#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_MAIN_H
