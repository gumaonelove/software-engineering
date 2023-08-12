//
// Created by Булат Гумеров on 27.02.2023.
//

//линейный динамический список( удаление - перемещение во вспомогательный стек)

#include "five.h"


void menu() {
    int number;
    string value;
    while (true) {
        cout << "1. Show list\n";
        cout << "2. Is list empty?\n";
        cout << "3. Add element\n";
        cout << "4. Delete element\n";
        cout << "5. Find element\n";
        cout << "6. Show stack\n";
        cout << "7. Clear list\n";
        cout << "8. Clear stack\n";
        cout << "0. Exit\n";
        cin >> number;
        if (number == 1) showList(); //1. Вывод текущего состояния списка на экран
        else if (number == 2) { //2. Проверка пустоты списка
            if (isListEmpty() == 1) cout << "\nList is empty\n";
            else cout << "\nlist is not empty\n";
        } else if (number == 3) {
            Push(); //3. Добавить элемент в список
        } else if (number == 4) {
            pop(); //4. Удалить элемент из списка
        } else if (number == 5) {
            find(); //5. Поиск элемента с заданной информационной частью
        } else if (number == 6) {
            showStack(); //6. Вывод текущего состояния вспомогательного стека на экран
        } else if (number == 7) {
            ClearList(); //7. Очистить список
        } else if (number == 8) {
            ClearStack(); //8. Очистить стек
        } else if (number == 0) {
            //0. Завершить работу
            ClearList(); //очистка списка
            ClearStack(); //очистка стека
            break;
        } else cout << "\nError. Try again.\n";
    }
}

int main()
{
    initList();
    initStack();
    menu();
    return 0;
}