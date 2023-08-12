//
// Created by Булат Гумеров on 17.02.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_CONFIG_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_CONFIG_H

#include <iostream>
#include <random>
#include <thread>
#include<chrono>
#include<iomanip>
#include<stdlib.h>
#include <ctime>
#include <stdio.h>
#include <fcntl.h>
#include <time.h>
#include <cstddef>

using namespace std;

char symbols[] = "QWERTYUIOPASDFGHJKLZXCVBNM";
int maxElementToAction = 3;
int secondsTime = 1;
int hours = 0, minutes = 0;
double seconds = 0;


struct QueueItem {
    string value;
    QueueItem* Next;
}*First, *Last;


void initQueue() {
    First = new QueueItem;
    First->Next = NULL;
    Last = First;
}

bool isEmpty() {
    if (First->Next == NULL) {
        return true;
    } else {
        return false;
    }
}

void ShowQueue() {
    if (!isEmpty()) {
        QueueItem* current;
        current = First->Next;
        int i = 1;
        while (current != NULL) {
            cout << i << ") " << current->value << endl;
            current = current->Next;
            i++;
        }
    } else {
        cout << "Очередь пуста" << endl;
    }
}

void push(char _value) {
    QueueItem* current = new QueueItem;
    current->value = _value;
    current->Next = NULL;
    Last->Next = current;
    Last = current;
}

string pop() {
    if (!isEmpty()) {
        QueueItem *current;
        current = First->Next;
        First->Next = current->Next;
        if (isEmpty()) {
            Last = First;
        }
        string _value = current->value;
        delete current;
        return _value;
    } else {
        cout << "Очередь пустая, удалять нечего" << endl;
        return "-1";
    }
}

#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_CONFIG_H