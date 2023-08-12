//
// Created by Булат Гумеров on 17.02.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_STACK_METHODS_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_STACK_METHODS_H

#include "Stack.h"

void Stack::push(int x) {
    if (isFull()) {
        cout << "Stack заполнен, добавление элемента " << x << " не возможно" << endl;
    } else {
        cout << "Добавление элемента " << x << " в Stack" << endl;
        arr[++top] = x;
    }
}

int Stack::pop() {
    if (isEmpty()){
        cout << "Stack пуст, удаление элемента не возможно" << endl;
    } else {
        cout << "Удаление элемента " << peek() << " из Stack " << endl;
        return arr[top--];
    };
}


int Stack::peek() {
    if (!isEmpty()){
        return arr[top];
    } else {
    }
}

int Stack::size() {
    return top + 1;
}

bool Stack::isEmpty() {
    return top == -1;
    // or return size == 0;
}

bool Stack::isFull() {
    return top == capacity - 1;
    // or return capacity == size;
}

void Stack::show() {
    for (int i = 0; i <= top; i++) {
        cout << arr[i] << ' ';
    }
}

#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_STACK_METHODS_H