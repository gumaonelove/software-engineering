//
// Created by Булат Гумеров on 17.02.2023.
//

#include "Stack_methods.h"

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
    int console_command_number, value;
    while (true)
    {
        cout << "\nВведите номер команды: " << endl;
        cout << "1. Вывести текущее состояние Stack в консоль" << endl;
        cout << "2. Добавить элемент в Stack" << endl;
        cout << "3. Удалить элемент из Stack"  << endl;
        cout << "4. Выполнить проверку пустоты Stack" << endl;
        cout << "5. Конец программы" << endl;
        cout << "Ваш выбор?" << endl;
        console_command_number = fail();

        if (console_command_number == 1) {
            cout << "Текущее состояние Stack" << endl;
            show(sp);
        }
        else if (console_command_number == 2)
        {
            cout << "Добавить элемент в Stack" << endl;
            cout << "Введите элемент" << endl;
            value = fail();
            sp = push(sp, value);
        }
        else if (console_command_number == 3)
        {
            pop();
        }
        else if (console_command_number == 4) {
            isEmpty();
        }
        else if (console_command_number == 5) {
            break;
        }
        else {
            cout << "Ошибка, попробуйте снова" << endl;
        }
    }
}


int main()
{
    init();
    menu();
    return 0;
}