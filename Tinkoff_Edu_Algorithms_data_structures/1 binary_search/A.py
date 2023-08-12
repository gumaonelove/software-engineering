'''
Задача A: Двоичный поиск
Реализуйте алгоритм бинарного поиска. Вам нужно ответить на несколько вопросов "Присутствует ли элемент
x
" в отсортированном массиве.
'''
n, k = map(int, input().split())
N = list(map(int, input().split()))
K = list(map(int, input().split()))


def binary_search(key):
    start_element = 0
    end_element = n - 1

    while start_element <= end_element:
        middle_element = (start_element + end_element) // 2

        if N[middle_element] == key:
            return "YES"
        elif N[middle_element] < key:
            start_element = middle_element + 1
        else:
            end_element = middle_element - 1
    return "NO"


for k_i in K:
    print(binary_search(k_i))