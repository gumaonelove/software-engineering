'''
Найти с заданной точностью корень функции F(x) = x**2 - 2 на отрезке (0, 5)
c помощью деления отрезка по полам
'''

from math import fabs

accuracy = float(input('Введите точность: '))

left, right = 0, 5
mid = (left + right) / 2

while fabs(mid ** 2 - 2) > accuracy:
    if mid ** 2 - 2 > 0:
        left, right = left, mid
        mid = (left + right) / 2
    elif mid ** 2 - 2 < 0:
        left, right = mid, right
        mid = (left + right) / 2

print(mid)