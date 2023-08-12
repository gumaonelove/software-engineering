//
// Created by Булат Гумеров on 18.04.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_MAIN_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_MAIN_H


//безконфликтная хештаблица для заданного набора ключей
#include <iostream>
using namespace std;
//хеш таблица - особый вид структуры данных
//где каждому ключу соответсвует индекс

//хеш функция-функция благодаря которой для входного ключа вычисляется индекс

int _hash(char* word)
{
    int sum = 0;
    for (int i = 0; i < strlen(word); i++)
    {
        sum += word[i];
    }
    sum = sum % 10 + 1;
    return sum;
}

int search(char* key, char** table)
{
    int index = _hash(key);
    if (strcmp(table[index], key) == 0)
    {
        return index;
    }
    else
    {
        return -1;
    }
}


#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_MAIN_H
