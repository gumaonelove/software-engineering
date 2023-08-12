'''
Задача B: Рядом
Вам дан отсортированный массив и запросы для поиска элемента, максимально близкого к запрошенному.
Если есть несколько значений с минимальной разницей по модулю, надо вывести минимальное.
'''

# Алгоритм приближенного бинарного поиска

n, k = map(int, input().split())
N = list(map(int, input().split()))[:n]
K = list(map(int, input().split()))[:k]


def left_binary_search(key):
    start_element = 0
    end_element = n - 1

    if key >= N[-1]:
        return N[-1]
    elif key <= N[0]:
        return N[0]

    while start_element < end_element:
        middle = (start_element + end_element) // 2
        if N[middle] < key:
            start_element = middle + 1
        else:
            end_element = middle

    if start_element > 0 and N[start_element] != key and abs(N[start_element - 1] - key) <= abs(N[start_element] - key):
        return N[start_element - 1]
    else:
        return N[start_element]


for k_i in K:
    left = left_binary_search(k_i)
    print(left)