//
// Created by Булат Гумеров on 18.03.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_MAIN_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_MAIN_H


//Построение и обработка двоичных деревьев поиска
//Двоичное дерево поиска - двоичное дерево, если для каждой вершины  все ключи ее левого поддерева меньше
//ключа самой вершины, а все ключи правого поддерева, больше ключа самой вершины

#include <iostream>

using namespace std;


int counter = 0;


struct Three {
    int value,count;//информационная часть и счетчик появлений ключа
    Three *left;
    Three *right;
}*Root,*Parent;//корень и родитель


//поиск
Three* find(Three *three, Three *parent, int _value)
{
    if (three != NULL) {
        Three* current = three;
        while (current != NULL) {
            if (current->value == _value) {
                return current;
            } else if (current->value > _value) {
                if (parent != NULL) {
                    parent = current;
                }
                current = current->left;
            } else if (current->value < _value) {
                if (parent != NULL) {
                    parent = current;
                }
                current = current->right;
            }
        }
        return NULL;
    } else {
        cout << "Дерево пусто" << endl;
        return NULL;
    }
}


//добавление c рекурсией
void Add(Three *&three, int _value)
{
    if (three == NULL) {
        three = new Three;
        counter++;
        three->value = _value;
        three->left = NULL;
        three->right = NULL;
        three->count = 1;
        return;
    } else {
        if (three->value < _value) {
            Add(three->right, _value);
        } else {
            if (three->value > _value){
                Add(three->left, _value);
            } else {
                three->count++;
            }
        }
    }
}


//добавление без рекурсии
void nonrecpush(int _value) {
    if (Root == NULL) {
        Root = new Three;
        Root->value = _value;
        Root->left = NULL;
        Root->right = NULL;
        Root->count = 1;
        return;
    } else {
        Three* parent = Root;
        Three* current = Root;
        while (current != NULL) {
            parent = current;
            if (_value > current->value){
                current = current->right;
            }
            else {
                if (_value < current->value){
                    current = current->left;
                } else {
                    current->count++; //current = NULL;
                }
            }
        }
        if (_value > parent->value) {
            parent->right = new Three;
            parent->right->value = _value;
            parent->right->count = 1;
            parent->right->left = NULL;
            parent->right->right = NULL;
            counter++;
        }
        if (_value < parent->value) {
            parent->left = new Three;
            parent->left->value = _value;
            parent->left->count = 1;
            parent->left->left = NULL;
            parent->left->right = NULL;
            counter++;
        }
    }
}


void show(Three *three,int level,Three *prev)
{
    if (three != NULL) {
        level++;
        show(three->right, level+1,three);
        string str;
        for (int i = 1; i < level; i++) {
            str += "   ";
        }
        cout << " " << str << three->value<<"("<<prev->value<<")" << endl;/* "(" << three->count << ")";*/
        show(three->left, level+1,three);
    }
}


void aapp(Three *three,int level)
{
    if (three != NULL) {
        level++;
        aapp(three->left, level);
        cout << three->value << " (" << three->count << ") " << endl;
        aapp(three->right, level);
    }
}


void Change(Three*& current, Three*& temp)
{
    // current - левое поддерево
    // temp - поддерево
    // если правое поддерево не пустое
    if (current->right != NULL) {
        // меняем правое поддерево
        Change(current->right, temp);
    } else {
        // правое поддерево пустое
        temp->value = current->value;
        temp = current;
        current = current->left;
    }
}


void pop(Three*& three, int _value)
{
    if (three != NULL)
    {
        if (_value < three->value) {
        /* если удаляемое значение меньше корня,
        будем рекурсивно удалять значение из левого поддерева */
            pop(three->left, _value);
        } else if (_value > three->value) {
            /* удаляемое значение больше корня
             будем рекурсивно удалять из правого поддерева*/
            pop(three->right, _value);
        } else {
            // удаляемое значение равно корню
            Three  *temp = three;
            // Если правое поддерево пустое, корнем становится левое поддерево
            if (temp->right == NULL) {
                three = temp->left;
            } else {
                // Если правое поддерево НЕ пустое, и левое поддерево пустое.
                // Корнем становится правое поддерево
                if (temp->left == NULL) {
                    three = temp->right;
                } else {
                    // Если правое поддерево не пустое и левое не пустое
                    Change(three->left, temp);
                    // меняем левое поддерево
                }
            }
            free(temp);
            counter--;
            }
        }
    }



void Destroy(Three *&three)
{
    if (three != NULL)
    {
        Destroy(three->left);
        Destroy(three->right);
        free(three);
        counter--;
        if (counter == 0) {
            three = NULL;
        }
    }

}


#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_MAIN_H