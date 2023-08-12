//
// Created by Булат Гумеров on 18.03.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_MAIN_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_MAIN_H


//произвольнеы двоичные деревья
#include <iostream>

using namespace std;

bool stop = false;
int counter = 0;


struct Three {
    int value;
    Three* left;
    Three* right;
}*Root,*Parent;


void find(Three *three, int _value)
{
    if (stop == true) return;
    else if (three != NULL) {
        if (three->value == _value) {
            stop = true;
            Parent = three;
            return;
        }
        find(three->left, _value);
        find(three->right, _value);
    }
}

void push() {
    int _value;
    if (Root == NULL) {
        Root = new Three;
        cout << "Введите вершину: " << endl;
        cin >> _value;
        Root->value = _value;
        Root->left = NULL;
        Root->right = NULL;
    } else {
        int auxvar;
        cout << "Введите ее отца" << endl;
        cin >> auxvar;
        Parent = NULL;
        stop = false;
        find(Root, auxvar);
        if (Parent != NULL) {
            Three *current = new Three;
            cout << "Введите ваш элемент" << endl;
            cin >> current->value;
            current->left = NULL;
            current->right = NULL;
            if ((Parent->left == NULL) && (Parent->right == NULL)) {
                int select;
                cout << "Добавление в :" << endl;
                cout << "1. Лево" << endl;
                cout << "2. Право" << endl;
                cin >> select;
                if (select == 1) {
                    Parent->left = current;
                } else if (select == 2) {
                    Parent->right = current;
                }
            } else {
                if (Parent->left == NULL) {
                    cout << "Добавление в лево" << endl;
                    Parent->left = current;
                } else if (Parent->right == NULL) {
                    cout << "Добавление в право" << endl;
                    Parent->right = current;
                } else {
                    cout << "Вы не можете добавить больше, уже 2 ребенка" << endl;
                }
            }
        } else {
            cout << "Не удалось найти родителя" << endl;
            return;
        }
    }
    counter++;
}


//ПОСТРОЧНЫЙ ВЫВОД В ПРЯМОМ НАПРАВЛЕНИИ
void Forward(Three* head, int level)
{
    if (head != NULL) {
        string str; //обработка корневой вершины head
        for (int i = 0; i < level; i++)
            str += "     ";
        cout << " " << str << head->value << "\n";
        Forward(head->left, level + 1); //обработка  всех левых поддеревьев
        Forward(head->right, level + 1); //обработка  всех правых поддеревьев
    }
}

//ПОСТРОЧНЫЙ ВЫВОД В СИММЕТРИЧНОМ НАПРАВЛЕНИИ
void Symmetric(Three* head, int level)
{
    if (head != NULL) {
        Symmetric(head->left, level + 1); //обработка  всех левых поддеревьев
        string str; //обработка корневой вершины head
        for (int i = 0; i < level; i++)
            str += "     ";
        cout << " " << str << head->value << "\n";
        Symmetric(head->right, level + 1); //обработка  всех правых поддеревьев
    }
}

void ReverseSummetry(Three *head, int level)
{
    if (head != NULL) {
        ReverseSummetry(head->right, level + 1); //обработка  всех правых поддеревьев
        string str; //обработка корневой вершины head
        for (int i = 0; i < level; i++)
            str += "     ";
        cout << " " << str << head->value << "\n";
        ReverseSummetry(head->left, level + 1); //обработка  всех левых поддеревьев
    }
}

void pop(Three *&head)
{
    if (head != NULL) {
        pop(head->left);
        pop(head->right);
        free(head);
        counter--;
        if (counter == 0) {
            head = NULL;
        }
    }
}


#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_MAIN_H
