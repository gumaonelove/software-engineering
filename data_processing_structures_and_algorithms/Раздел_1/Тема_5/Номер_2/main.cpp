//
// Created by Булат Гумеров on 18.03.2023.
//

#include "balanced_tree.h"
#include "funcs.h"

int main() {
    srand(static_cast<unsigned int>(time(0))); //инициализация генератора псевдослучайных чисел rand
    while (true) {
        N = -1;
        //ПОСТРОЕНИЕ ИСД С ЗАДАННЫМ ЧИСЛОМ ВЕРШИН
        while (N <= 0)
        {
            cout << "Сколько вершин хотите добавить?" << endl;
            cin >> N;
            if (N <= 0) {
                cout << "Ошибка, попробуйте снова" << endl;
            } else {
                pRoot = AddNodes(pRoot, N);
                cout << "ИДЕАЛЬНО СБАЛАНСИРОВАННОЕ ДВОИЧНОЕ ДЕРЕВО" << endl;
                cout << "С НЕРЕКУРСИВНЫМ ВАРИАНТОМ СИММЕТРИЧНОГО ОБХОДА (ВСПОМОГАТЕЛЬНЫЙ СТЕК)" << endl;
                cout << "Успешно создано" << endl;
            }
        }

        cout << "ПОСТРОЧНЫЙ ВЫВОД В СИММЕТРИЧНОМ НАПРАВЛЕНИИ" << endl;
        Symmetric(pRoot, 0);

        cout << "НЕРЕКУРСИВНЫЙ ВЫВОД В СИММЕТРИЧНОМ НАПРАВЛЕНИИ" << endl;
        Nonrecursive();

        delTp(pRoot);
    }
    return 0;
}
