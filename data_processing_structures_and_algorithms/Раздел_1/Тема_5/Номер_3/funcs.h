//
// Created by Булат Гумеров on 18.03.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_TREE_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_TREE_H

#include "tree.h"

void menu() {
    int select = 0;
    while (select != 5) {
        cout << "Выберите команду:" << endl;
        cout << "1. Добавить элемент" << endl;
        cout << "2. Найти" << endl;
        cout << "3. Распечатать" << endl;
        cout << "4. Удалить дерево" << endl;
        cout << "5. Выйти" << endl;
        cin >> select;

        if (select == 1) {
            push();
        } else if (select == 2) {
            if (Root != NULL) {
                cout << "Введите элемент который хотите найти" << endl;
                int _value;
                cin >> _value;
                Parent = NULL;
                stop = false;
                find(Root, _value);
                if (Parent != NULL) {
                    cout << "Элемент " << _value << " найден" << endl;
                } else {
                    cout << "Элемент " << _value << " не найден" << endl;
                }
            } else {
                cout << "Дерево пустое" << endl;
            }
        } else if (select == 3) {
            if (Root != NULL)
            {
                int choice = -1;
                while (choice == -1) {
                    cout << "Выберите действие:" << endl;
                    cout << "1. Прямой вывод" << endl;
                    cout << "2. Симметричный вывод" << endl;
                    cout << "3. Симметричный в обратном направлении вывод" << endl;
                    cin >> choice;
                    if (choice == 1) {
                        Forward(Root, 0);
                        break;
                    } else if (choice == 2) {
                        Symmetric(Root, 0);
                        break;
                    } else if (choice == 3) {
                        ReverseSummetry(Root, 0);
                        break;
                    } else {
                        cout << "Ошибка попробуйте снова" << endl;
                        choice = -1;
                    }
                }
            } else {
                cout << "Ошибка, создайте дерево" << endl;
            }
        } else if (select == 4) {
            pop(Root);
        } else if (select == 5){
            break;
        } else {
            cout << "Ошибка попробуйте снова" << endl;
        }
    }
}

#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_TREE_H
