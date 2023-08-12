//
// Created by Булат Гумеров on 17.02.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_STACK_METHODS_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_STACK_METHODS_H

#include "Stack.h"
extern int fail();

Stack *push(Stack* _sp, int _value) {
    Stack *item = new Stack;
    item->value = _value;
    item->next = _sp;
    _sp = item;
    cout << "Добавление элемента " << _value << " в Stack" << endl;
    return _sp;
}

void pushRand()
{
    int newCount;
    std:cout << "Сколько элементов вы хотите добавить? " << endl;
    newCount = fail();
    for (int i = 0; i < newCount; i++)
    {
        sp = push(sp, rand());
    }
}

bool isEmpty(Stack* _sp) {
    if (_sp == NULL) {
        return true;
    } else{
        return false;
    }
}

int pop() {
    int value = sp->value;

    if (isEmpty(sp)){
        cout << "Stack пуст, удаление элемента не возможно" << endl;
        return 0;
    } else {
        Stack* current = sp;
        sp = sp->next;
        delete current;
        cout << "Удаление элемента " << value << " из Stack " << endl;
        return value;
    };
}

void show(Stack* _sp) {
    if (_sp != NULL) {
        Stack *current;
        current = _sp;
        do {
            cout << current->value << endl;
            current = current->next;
        } while (current != NULL);
    } else {
        cout << "Stack пуст" << endl;
    }
}

#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_STACK_METHODS_H