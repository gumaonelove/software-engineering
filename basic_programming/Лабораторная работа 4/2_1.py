'''
Найти с заданной точностью корень функции F(x) = x**2 - 2 на отрезке (0, 5)
c помощью деления отрезка по полам
'''

from math import fabs


def binary_search(left, right, accuracy):
    """
    рекурсивный бинарный поиск
    """
    mid = (left + right) / 2
    if fabs(mid**2 - 2) <= accuracy:
        print(mid)
        return
    elif mid ** 2 - 2 > 0:
        binary_search(left, mid, accuracy)
    elif mid ** 2 - 2 < 0:
        binary_search(mid, right, accuracy)


binary_search(
    left=0,
    right=5,
    accuracy=float(input('Введите точность: '))
)


