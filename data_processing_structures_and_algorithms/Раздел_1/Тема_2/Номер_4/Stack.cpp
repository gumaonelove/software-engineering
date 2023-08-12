//
// Created by Булат Гумеров on 17.02.2023.
//

#include "second.h"

int fail() {
    int a;
    while (!(cin >> a) || (cin.peek() != '\n'))
    {
        cin.clear();
        while (cin.get() != '\n');
        cout << "\n Ошибка! Попробуйте снова" << endl;
    }
    return a;
}

void menu()
{
    int console_command_number, value, auxiliary_console_command_number;
    while (true)
    {
        cout << "\nВведите номер команды: " << endl;
        cout << "1. Вывести текущее состояние Stack в консоль" << endl;
        cout << "2. Добавить элемент в Stack" << endl;
        cout << "3. Добавить несколько элементов в Stack" << endl;
        cout << "4. Удалить элемент из Stack"  << endl;
        cout << "5. Выполнить проверку пустоты Stack" << endl;
        cout << "6. Вывести текущее состояние вспомогательного Stack в консоль" << endl;
        cout << "7. Конец программы" << endl;
        cout << "Ваш выбор?" << endl;
        console_command_number = fail();

        if (console_command_number == 1) {
            cout << "Текущее состояние Stack" << endl;
            show(sp);
        } else if (console_command_number == 2) {
            cout << "Выберите вариант добавления: " << endl;
            cout << "1. Создание нового элемента" << endl;
            cout << "2. Выбор его с вершины вспомогательного стека";
            auxiliary_console_command_number = fail();
            if (auxiliary_console_command_number == 1) {
                cout << "Добавить элемент в Stack" << endl;
                cout << "Введите элемент" << endl;
                value = fail();
                sp = push(sp, value);
            } else if (auxiliary_console_command_number == 2) {
                add_from_second();
            } else {
                cout << "Ошибка, повторите попытку" << endl;
            }
        } else if (console_command_number == 3) {
            pushRand();
        }
        else if (console_command_number == 4) {
            cout << "Выберите вид удаления: " << endl;
            cout << "1. Удалить элемент с освобождением памяти" << endl;
            cout << "2. Включить его в вершину вспомогательного стека удаленных элементов" << endl;
            auxiliary_console_command_number = fail();
            if (auxiliary_console_command_number == 1) {
                pop();
            } else if (auxiliary_console_command_number == 2) {
                MoveToSecondStack();
            } else {
                cout << "Ошибка, повторите попытку" << endl;
            }
        } else if (console_command_number == 5) {
            isEmpty(sp);
        } else if (console_command_number == 6) {
            cout << "Текущее состояние  вспомогательного Stack" << endl;
            show(sp_auxiliary);
        } else if (console_command_number == 7) {
            break;
        } else {
            cout << "Ошибка, попробуйте снова" << endl;
        }
    }
}


int main()
{
    init();
    srand(static_cast<unsigned int> (time(0)));
    menu();
    return 0;
}