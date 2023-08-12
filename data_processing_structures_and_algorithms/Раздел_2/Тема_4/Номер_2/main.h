//
// Created by Булат Гумеров on 18.04.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_MAIN_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_MAIN_H


//внутреннее хеширование
#include <iostream>

using namespace std;
//внутреннее хеширование
//если два ключа претендуют на одно место тоББ то он помещается в след ячейку
//хеш - таблица - массив, заполненный элементами исходного набора в порядке, определяемом хеш - функцией.

int _hash(char* word, int m)
{
    int sum = 0;
    for (int i = 0; i < strlen(word); i++)
    {
        sum += word[i];
    }
    return sum % m + 1;
}


#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_MAIN_H
