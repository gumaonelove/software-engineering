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
} *sp, *sp_auxiliary;


void init(){
    sp = NULL;
    sp_auxiliary = NULL;
}

#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_STACK_H