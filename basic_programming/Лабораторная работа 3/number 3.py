'''
Задание 3. Варианты заданий на удаление элементов списка.
Элементы списка вводить с помощью генератора случайный чисел

8. В одномерном списке A=(a1, а2, ..., аn) удалить все равные элементы,
оставив только один из данных групп равных.
'''
from functions import get_list

start = int(input('start: '))
stop = int(input('stop: '))
count = int(input('count: '))

our_list = get_list(start, stop, count)
new_list = []

print(our_list)

for number in our_list:
    if number not in new_list:
        new_list.append(number)

print(new_list)