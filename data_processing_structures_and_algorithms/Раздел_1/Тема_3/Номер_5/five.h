//
// Created by Булат Гумеров on 28.02.2023.
//

#ifndef DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_FIVE_H
#define DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_FIVE_H

#include <iostream>
#include <string>


using namespace std;
int counter=0;

struct List {
    string value;//информационная часть элемента
    List* next;//ссылочная переменная указатель
}*head, *stackhead;//head -заголовок списка, secondhead- вершина вспомогательного стека

void initList() {//инициализация основого списка
    head = new List();//заголовок
    head->next = NULL;//занесение в загловок пустого указателя
}

void initStack() { //инициализация вспомогательного стека
    stackhead = new List();
    stackhead->next = NULL;
}
//проверка пустоты списка и стека
bool isListEmpty() {
    if (head->next == NULL) return 1;
    else return 0;
}

bool isStackEmpty() {
    if (stackhead->next == NULL) return 1;
    else return 0;
}
//вывод состояния списка
void showList() {
    if (!isListEmpty()) {
        int i = 1;
        List* current;//ввод вспомогательной переменной

        current = head->next;//установка в адрес первого элемента
        while (current != NULL){
            cout << i << ")" << current->value << "\n";
            current = current->next;
            i++;
        }
    }
    else cout << "\nList is empty\n";
}
//аналогичная функция для стека
void showStack() {
    if (!isStackEmpty()) {
        int i = 1;
        List* current;//ввод вспомогательной переменной
        current = stackhead->next;//установка в адрес первого элемента
        while (current != NULL) {
            cout << i << ")" << current->value << "\n";
            current = current->next;
            i++;
        }
    }
    else cout << "\nStack is empty\n";
}

void before() {
    string _value;
    string __value;
    List* current = NULL;//вспомогательнаяссылчоная  перменная
    List* temp = new List;//вспомогательная сылчоная перменная для нового добавляемого элемента
    cout << "\nEnter element before which you want to add\n";
    showList();cin.clear(); cin.ignore(32767, '\n'); getline(cin, _value);

    List* pred;//ввод вспомогательной ссылчной переменной(предшествующая current)
    pred = head;//установка в заголовок ( current идет с первого реального элемента)
    current = head->next;//установка current в адрес первого реального элемента
    while (current != NULL) {
        if (current->value == _value) break;
        current = current->next;
        pred = pred->next;
    }
    temp->next = current;//новое поле для элемента(ссылчоная часть)
    pred->next = temp;//изменение ссычлоной части элемента предшественика на адрес нового элемента
    cout << "\n Enter value:\n"; cin.clear(); getline(cin, __value);
    cout << "\n Element is added\n"; temp->value = __value;
}
void after() {
    string _value,__value;
    List* current = NULL;//вспомогательнаяссылчоная  перменная
    List* temp = new List;//вспомогательная сылчоная перменная для нового добавляемого элемента
    current = head->next;
    cout << "\nEnter element after which you want to add\n";
    showList(); cin.clear(); cin.ignore(32767, '\n'); getline(cin, _value);
    while ((current != NULL) && (current->value != _value)){
        if (current->value == _value) break;
        current = current->next;
    }
    temp->next = current->next;//новое поле для ссылочной части
    current->next = temp;//изменение ссылочной части нового элемента на адрес нового элемента
    cout << "\n Enter value:\n"; //cin.clear();
    cin >> __value;
    //cin.ignore(32767, '\n'); getline(cin, __value);
    cout << "\n Element is added\n"; temp->value = __value;
}

void Push() {
    string _value;
    if (counter == 0) {
        cout << "\nEnter your element:\n";
        cin.clear(); cin.ignore(32767, '\n'); getline(cin, _value);
        List* temp = new List();
        temp->value = _value;
        temp->next = NULL;
        head->next = temp;
        counter++;
        cout << "\nElement is add\n";
    } else {
        int choice;
        cout << "\nWhere you want to add element?\n0 - before\n1-after";
        cin >> choice;
        if (choice == 0) {
            before();
        }
        else if (choice == 1) {
            after();
        }
        else cout << "\nError. Enter '1' or '0'\n";
    }
}
void pop() {
    if (!isListEmpty()) {
        string _value;
        List* current;//ввод вспомогательной ссылочной переменной
        List* pred;//еще одна вспомогательная, пердшествующая curernt
        current = head->next;//установка current  в адрес первого элемента
        pred = head;//установка pred  в заголовок
        int choice = -1;
        int i = -1;
        while ((choice != 1) && (choice != 0)) {
            cout << "\nWhat you want to do:\n0- delete\n1-remove to auxiliary stack";
            cin >> choice;
            showList();

            while (i == -1) {
                cout << "\nEnter element what you want to delete:\n"; cin.clear(); cin.ignore(32767, '\n'); getline(cin, _value);
                while (current != NULL) {
                    if (current->value == _value) break;
                    current = current->next;
                    pred = pred->next;
                }
                if (current != NULL) {
                    i++;
                    cout << "\nElement" << _value << "is found\n";
                }
                else cout << "\nElement is not found\n";
            }
            if (choice == 0) {
                pred->next = current->next;//изменение связующей части элемента предшественника на связующую часть удаляемого элемента
                delete current;
                cout << "\nElement" << current->value << "is delete\n";
            }
            else if (choice == 1) {
                pred->next = current->next;// в основном списке изменение связующей части элемента предшественника на связующую часть удаляемого элемента
                List* temp = current;//ввод вспомогательной ссылочной перменной для нового элемента в стеке
                temp->next = stackhead->next;
                stackhead->next = temp;
                cout << "\nElement" << current->value << "is delete\n";
            }
            else {
                cout << "Error. Try choice command again";
            }
        }
    }
    else cout << "Error.List is empty";
}

void find() {
    if (!isListEmpty()) {
        showList();
        string _value;
        cout << "\nEnter value what you want find\n";
        cin.clear();
        cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
        getline(cin, _value);
        int i = 1;
        List* current;
        current = head->next;
        while ((current != NULL) && (current->value != _value)) {
            current = current->next;
            i++;
        }
        if (current != NULL) cout << "\nElement" << _value << " is found. His number is :" << i << "\n";
        else cout << "\nElement" << _value << "is not found\n";
    }
    else cout << "\n List is empty.Nothing to find\n";
}

//Очистка списка перед завершением работы программы (освобождение памяти)
inline void ClearList() {
    List* current; //ввод вспомогательной ссылочной переменной
    while (head != NULL) { //особождение памяти, занятой под основной список
        current = head;
        head = head->next;
        delete current;
    }
    initList(); //повторная инициалиция, создание пустого списка
}
//Очистка вспомогательного стека перед завершением работы программы (освобождение памяти)
inline void ClearStack() {
    List* current; //ввод вспомогательной ссылочной переменной
    while (stackhead!= NULL) { //особождение памяти, занятой под вспомогательный список (стек)
        current = stackhead;
        stackhead = stackhead->next;
        delete current;
    }
    initStack(); //повторная инициалиция, создание пустого вспомогательного стека
}


#endif //DATA_PROCESSING_STRUCTURES_AND_ALGORITHMS_FIVE_H
