//
// Created by Булат Гумеров on 28.02.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_ONE_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_ONE_H


#include <iostream>

struct Item
{
    int data;
    Item* next;
    Item* prev;
};

Item* head;

void Init()
{
    head = new Item;
    head->next = head;
    head->prev = head;
}

int Input()
{
    int a;
    while (!(std::cin >> a) || (std::cin.peek() != '\n'))
    {
        std::cin.clear();
        while (std::cin.get() != '\n');
        std::cout << "Ошибка ввода, попробуйте снова!\n";
    }
    return a;
}

bool FindValue(int value, bool isStraight)
{
    if (isStraight)
    {
        auto current = head->next;
        while (current != head)
        {
            if (current->data == value)
                return true;
            current = current->next;
        }
    }
    else
    {
        auto current = head->prev;
        while (current != head)
        {
            if (current->data == value)
                return true;
            current = current->prev;
        }
    }
    return false;
}

Item* getItem(int value)
{
    auto current = head->next;
    while (current != head)
    {
        if (current->data == value)
            return current;
        current = current->next;
    }
}

void AddBefore(int add_value, int value) {
    auto item = getItem(value);
    auto add = new Item;
    add->data = add_value;
    add->next = item;
    add->prev = item->prev;
    item->prev->next = add;
    item->prev = add;
}

void AddAfter(int add_value, int value) {
    auto add = new Item;
    add->data = add_value;
    if (head->next == head) {
        head->next = add;
        head->prev = add;
        add->next = head;
        add->prev = head;
    } else {
        auto item = getItem(value);
        add->next = item->next;
        add->prev = item;
        item->next->prev = add;
        item->next = add;
    }
}

void Show(bool isStraight)
{
    if (isStraight)
    {
        auto current = head->next;
        while (current != head)
        {
            std::cout << current->data << "\n";
            current = current->next;
        }
    }
    else
    {
        auto current = head->prev;
        while (current != head)
        {
            std::cout << current->data << "\n";
            current = current->prev;
        }
    }
}

void Delete(int value) {
    auto del = getItem(value);
    del->prev->next = del->next;
    del->next->prev = del->prev;

    delete del;
}


#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_ONE_H
