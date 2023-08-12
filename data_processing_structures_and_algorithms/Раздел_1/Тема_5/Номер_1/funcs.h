//
// Created by Булат Гумеров on 18.03.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_FUNCS_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_FUNCS_H

#include "balanced_tree.h"


//ПОСТРОЧНЫЙ ВЫВОД В ПРЯМОМ НАПРАВЛЕНИИ
void Forward(Tp* pCurrent, int level)
{
    if (pCurrent != NULL) {
        string str; //обработка корневой вершины pCurrent
        for (int i = 0; i < level; i++)
            str += "     ";
        cout << " " << str << pCurrent->value << "\n";

        Forward(pCurrent->Left, level + 1); //обработка  всех левых поддеревьев
        Forward(pCurrent->Right, level + 1); //обработка  всех правых поддеревьев
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


//ПОСТРОЧНЫЙ ВЫВОД В ОБРАТНО-СИММЕТРИЧНОМ НАПРАВЛЕНИИ
void BackSymmetric(Tp* pCurrent, int level) {
    if (pCurrent != NULL) {
        BackSymmetric(pCurrent->Right, level + 1); //обработка  всех правых поддеревьев

        string str; //обработка корневой вершины pCurrent
        for (int i = 0; i < level; i++)
            str += "     ";
        cout << " " << str << pCurrent->value << "\n";

        BackSymmetric(pCurrent->Left, level + 1); //обработка  всех левых поддеревьев
    }
}

#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_FUNCS_H
