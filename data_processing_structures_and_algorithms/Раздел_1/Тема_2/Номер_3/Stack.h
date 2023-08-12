//
// Created by Булат Гумеров on 17.02.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_STACK_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_STACK_H

#include <iostream>
#include <cstdlib>
using namespace std;


struct Stack {
    int value;
    Stack *next;
} *sp;


void init(){
    sp = NULL;
}

#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_STACK_H