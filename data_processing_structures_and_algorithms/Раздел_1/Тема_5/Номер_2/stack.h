//
// Created by Булат Гумеров on 18.03.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_STACK_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_STACK_H

#include "balanced_tree.h"

struct Stack {
    int level; //"уровень" вершины
    Tp* Point; //указатели на пройденную вершину дерева
    Stack* next; //указатели на следующий элемент стека
} *sp; // sp - указатель вершины главного стека


//инициализация, создание пустого стека
inline void initStack(Tp* pRoot) {
    sp = new Stack;
    sp->Point = pRoot;
    sp->level = -1;
    sp->next = NULL;
}

// Проверка пустоты стека
bool isEmpty() {
    if (sp->level < 0) return 1;
    else return 0;
}

#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_STACK_H
