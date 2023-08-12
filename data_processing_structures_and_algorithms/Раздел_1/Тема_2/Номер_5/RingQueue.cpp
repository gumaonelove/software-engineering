//
// Created by Булат Гумеров on 17.02.2023.
//

#include "RingQueue.h"

int fail() {
    int a;
    while (!(cin >> a) || (cin.peek() != '\n'))
    {
        cin.clear();
        while (cin.get() != '\n');
        cout << "Ошибка попробуйте снова" << endl;
    }
    return a;
}

void menu(int *queue_array) {
    while (true) {
        int menu_number, auxiliary_value;
        cout << "\nВыберите команду:" << endl;
        cout << "1. Очередь пустая?" << endl;
        cout << "2. Очередь полная?" << endl;
        cout << "3. Добавить элемент в конец" << endl;
        cout << "4. Удалить элемент из очереди" << endl;
        cout << "5. Оказать очередь" << endl;
        cout << "6. Завершить программу" << endl;
        menu_number = fail();

        if (menu_number == 1) {
            if (IsEmpty()) {
                cout << "Очередь пустая" << endl;
            } else {
                cout << "Очередь не пуста" << endl;
            }
        } else if (menu_number == 2){
            if (IsFull()) {
                cout << "Очередь полна" << endl;
            } else {
                cout << "Очередь не полна" << endl;
            }
        } else if (menu_number == 3) {
            if (!IsFull()) {
                cout << "Введите значение" << endl;
                int auxiliary_value = fail();
                push(queue_array, auxiliary_value);
            } else {
                cout << "Очередь полна" << endl;
            }
        } else if (menu_number == 4) {
            int value = pop(queue_array);
            if (value != -1) {
                cout << "Элемент " << value << " удален" << endl;;
            }
        } else if (menu_number == 5) {
            cout << "Очередь: " << endl;
            show_queue(queue_array);
        } else if (menu_number == 6) {
            break;
        } else{
            cout << "Ошибка попробуйте снова" << endl;
        }
    }
}

int main() {
    int queue_array[array_size];
    menu(queue_array);
    return 0;
}