//
// Created by Булат Гумеров on 18.03.2023.
//

#include "balanced_tree.h"
#include "funcs.h"


int main() {
    srand(static_cast<unsigned int>(time(0))); //инициализация генератора псевдослучайных чисел rand
    while (true) {
        N = -1;
        while (N <= 0) {
            cout << "Сколько вершин вы хотите добавить?" << endl;
            cin >> N;
            if (N <= 0) {
                cout << "Ошибка, попробуйте снова" << endl;
            } else {
                pRoot = AddNodes(pRoot, N);
                cout << "ИДЕАЛЬНО СБАЛАНСИРОВАННОЕ ДВОИЧНОЕ ДЕРЕВО Создано" << endl;
            }
        }
        cout << "Обход дерева в прямом направлении:" << endl;
        Forward(pRoot, 0);

        cout << "Симметричный обход" << endl;
        Symmetric(pRoot, 0);

        cout << "Обход в обратном симметричном направлении:" << endl;
        BackSymmetric(pRoot, 0);

        delTp(pRoot);
    }

    return 0;
}