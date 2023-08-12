//
// Created by Булат Гумеров on 18.03.2023.
//

#include "main.h"


int main() {
    int select=0;
    while (select != 7) {
        cout << "Выберете команду:" << endl;
        cout << "1. Создать дерево" << endl;
        cout << "2. Добавить вершину" << endl;
        cout << "3. Найти вершину" << endl;
        cout << "4. Распечатать в обратно симметричном порядке" << endl;
        cout << "5. Удалить вершину" << endl;
        cout << "6. Удалить дерево" << endl;
        cout << "7. Выйти" << endl;
        cout << "8. Распечатать в прямом порядке" << endl;
        cin >> select;
        if (select == 1) {
            int count;
            cout << "Введите количество вершин:" << endl;
            cin >> count;
            for (int i = 0; i < count; i++)
            {
                if (i == 0) {
                    Add(Root, count / 2);
                } else {
                    int _value = rand() % 100 + 1;
                    Add(Root, _value);
                }
            }
        } else if (select == 2) {
            int _choice;
            cout << "Вид добавления вершины" << endl;
            cout << "1. Рекурсивное добавления вершины" << endl;
            cout << "2. НЕ рекурсивное добавления вершины" << endl;
            cin >> _choice;
            if (_choice == 1)
            {
                int _value;
                cout << "Введите вершину" << endl;
                cin >> _value;
                Add(Root, _value);
            } else if (_choice == 2) {
                int _value;
                cout << "Введите вершину" << endl;
                cin >> _value;
                nonrecpush(_value);
            }
        } else if (select == 3) {
            int _value;
            cout << "Какую вершину вы хотите найти" << endl;
            cin >> _value;
            Three* found = find(Root, NULL, _value);
            if (found == NULL) {
                cout << "Вершина не найдена" << endl;
                continue;
            }
            cout << "found->value = " << found->value << "found->coun = " << found->count << endl;
        } else if (select == 4) {
            if (Root != NULL) {
                show(Root, 0,Root);
            } else {
                cout << "Дерево пусто" << endl;
            }
        } else if (select == 5) {
            if (Root != NULL) {
                int _value;
                cout << "Введите вершину которую хотите удалить" << endl;
                cin >> _value;
                pop(Root, _value);
            } else {
                cout << "Нечего удалять" << endl;
            }
        } else if (select == 6) {
            Destroy(Root);
        } else if (select == 7) {
            break;
        } else if (select == 8) {
            aapp(Root,0);
        } else  {
            cout << "Ошибка, попробуйте снова" << endl;
        }
    }
}