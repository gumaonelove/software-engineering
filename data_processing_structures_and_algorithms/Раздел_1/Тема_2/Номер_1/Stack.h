//
// Created by Булат Гумеров on 17.02.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_STACK_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_STACK_H

#include <iostream>
#include <cstdlib>
using namespace std;

#define SIZE 10

struct Stack {
    int *arr;
    int top;
    int capacity;

public:
    Stack(int size = SIZE);
    ~Stack();

    void push(int);
    int pop();
    int peek();

    void show();
    int size();
    bool isEmpty();
    bool isFull();
};

Stack::Stack(int size) {
    arr = new int[size];
    capacity = size;
    top = -1;
}

Stack::~Stack() {
    delete[] arr;
}

#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_STACK_H