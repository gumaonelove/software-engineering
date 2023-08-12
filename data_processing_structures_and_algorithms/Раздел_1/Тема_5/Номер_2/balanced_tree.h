//
// Created by Булат Гумеров on 18.03.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_MAIN_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_MAIN_H


//ИДЕАЛЬНО СБАЛАНСИРОВАННОЕ ДВОИЧНОЕ ДЕРЕВО С НЕРЕКУРСИВНЫМ ВАРИАНТОМ СИММЕТРИЧНОГО ОБХОДА (ВСПОМОГАТЕЛЬНЫЙ СТЕК)

#include <iostream>
#include <cstdlib>

using namespace std;


int N; //количество вершин в дереве, глобальная переменная


//ОПИСАНИЕ СТРУКТУРЫ ДЕРЕВА TreePoint
struct Tp {
    int value; //строка-значение
    Tp* Left; //ссылочная переменная-указатель на левый элемент
    Tp* Right; //ссылочная переменная-указатель на правый элемент
} *pRoot; //ссылочная переменная для адреса корневой вершины.


Tp* AddNodes(Tp* pCurrent, int aN) { //ДОБАВЛЕНИЕ ВЕРШИН (ПОСТРОЕНИЕ ИСД)
    Tp* pTemp;
    int Nl, Nr;
    if (aN == 0)  // если нет вершин для размещения
        return NULL; // формируем пустую ссылку
    else {
        Nl = aN / 2; //число вершин слева
        Nr = aN - Nl - 1; //число вершин справа
        pTemp = new Tp; //создаем корень поддерева, выделяем память
        pTemp->value = rand() % 100; //заносим в информационную часть случайное целое число в интервале от 0 до 99
        pTemp->Left = AddNodes(pTemp->Left, Nl); // уходим на создание левого поддерева
        pTemp->Right = AddNodes(pTemp->Right, Nr);
        pCurrent = pTemp;
        //        cout << "\n Вершина создана\n";
        return pTemp; //возвращаем адрес созданного корня
    }
}


//ОЧИСТКА ПАМЯТИ (УДАЛЕНИЕ ВЕРШИН ДЕРЕВА)
void delTp(Tp* pCurrent) {
    if (pCurrent != NULL) {
        delTp(pCurrent->Left); // сначала удалять все элементы с левого конца
        delTp(pCurrent->Right); // потом удалять все элементы с правого конца
        delete pCurrent; // в конце удалить сам элемент-корень
    }
};

#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_MAIN_H
