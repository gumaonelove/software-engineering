//
// Created by Булат Гумеров on 18.03.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_FUNCS_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_FUNCS_H


#include "balanced_tree.h"
#include "stack.h"


//НЕРЕКУРСИВНЫЙ ВЫВОД В СИММЕТРИЧНОМ НАПРАВЛЕНИИ
void Nonrecursive()
{
    initStack(pRoot);
    Tp* pCurrentTree = pRoot; //начинаем с корневой вершины дерева
    bool Stop = false;
    int level = 0;

    while (!Stop) {
        while (pCurrentTree != NULL) {

            Stack* item = new Stack; //занести pCurrent в стек
            item->level = level;
            item->Point = pCurrentTree;
            item->next = sp;
            sp = item;
            pCurrentTree = sp->Point;
            pCurrentTree = pCurrentTree->Left;
            level++;
        }
        if (isEmpty()) //если стек пуст
            Stop = true; //завершить основной цикл
        else { //обработка и вывод вершины
            level = sp->level;
            pCurrentTree = sp->Point;
            string str = ""; //обработка корневой вершины pCurrent
            for (int i = 0; i < level; i++)
                str += "     ";
            cout << " " << str << (pCurrentTree->value) << "\n";
            Stack* current = sp;
            sp = sp->next;
            delete current;
            pCurrentTree = pCurrentTree->Right;
            level++;
        }
    }
}


//ПОСТРОЧНЫЙ ВЫВОД В СИММЕТРИЧНОМ НАПРАВЛЕНИИ
void Symmetric(Tp* pCurrent, int level)
{
    if (pCurrent != NULL) {
        Symmetric(pCurrent->Left, level + 1); //обработка  всех левых поддеревьев
        string str; //обработка корневой вершины pCurrent
        for (int i = 0; i < level; i++)
            str += "     ";
        cout << " " << str << pCurrent->value << "\n";
        Symmetric(pCurrent->Right, level + 1); //обработка  всех правых поддеревьев
    }
}


#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_FUNCS_H
