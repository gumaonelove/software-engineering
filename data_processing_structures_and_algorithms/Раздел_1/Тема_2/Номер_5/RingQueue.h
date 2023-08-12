//
// Created by Булат Гумеров on 17.02.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_RINGQUEUE_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_RINGQUEUE_H

#include <iostream>
using namespace std;


const int array_size = 5;
int First, Last, array_count = 0;


bool IsEmpty() {
    if (array_count == 0) {
        return true;
    } else {

        return false;
    }
}

bool IsFull() {
    if (array_count == array_size) {
        return true;
    } else {
        return false;
    }
}

void push(int *queue_array, int value)

{
    if (!IsFull()) {
        queue_array[Last] = value;
        Last++;
        if (Last == array_size) {
            Last = 0;
        }
        array_count++;
    } else {
        cout << "Ошибка очередь полна, попробуйте снова" << endl;
    }
}

int pop(int *queue_array) {
    if (!IsEmpty()) {
        int value = queue_array[First];
        First++;
        if (First == array_size) First = 0;
        array_count--;
        return value;
    } else {
        cout << "Ошибка очередь пуста, попробуйте снова" << endl;
        return -1;
    }
}

void show_queue(int* queue_array) {
    if (!IsEmpty()) {
        cout << "\n";
        int current = First;
        int i = 1;
        do {
            cout << i << ") " << queue_array[current] << "\n";
            current++;
            if (current == array_size) current = 0;
            i++;
        } while (current != Last);
    }
}

#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_RINGQUEUE_H