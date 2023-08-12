'''
Задание 1. Дана строка, заканчивающаяся точкой.
a. Вывести длину строки.
b. Подсчитать, сколько слов в строке.
c. Найти длину самого короткого слова и самого длинного слова отличный'''

string = str(input('Введите строку: '))
last_index = string.rfind('.')
print(f'Длина строки: {len(string)} символов')
words = string.split()
print(f'В строке {len(words)} слов')
print(f'Длина минимального слова: {len(min(words))} символов')
print(f'Длина максимального слова: {len(max(words))} символов')
string = string.replace('*', '')
new_string = ''
for char in string:
    new_string += char*2
print(f'Новая строка: {new_string}')