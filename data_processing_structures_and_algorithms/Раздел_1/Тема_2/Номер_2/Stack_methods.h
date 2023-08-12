//
// Created by Булат Гумеров on 17.02.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_STACK_METHODS_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_STACK_METHODS_H

#include "Stack.h"

Stack *push(Stack* _sp, int _value) {
    Stack *item = new Stack;
    item->value = _value;
    item->next = _sp;
    _sp = item;
    cout << "Добавление элемента " << _value << " в Stack" << endl;
    return _sp;
}

bool isEmpty() {
    if (sp == NULL) {
        return true;
    } else{
        return false;
    }
}

void pop() {
    if (isEmpty()){
        cout << "Stack пуст, удаление элемента не возможно" << endl;
    } else {
        int value = sp->value;
        Stack* current;
        current = sp;
        sp = sp->next;
        delete current;
        cout << "Удаление элемента " << value << " из Stack " << endl;
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