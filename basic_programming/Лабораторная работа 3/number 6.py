'''
Задание 6. Поиск наибольшего числа в трёхмерном массиве.
Пусть массив Т имеет размерность 3х5х7. Найти наибольшее содержащееся в нем
число и вывести его и его индексы на экран.
'''
from random import randint

x, y, z = 3, 5, 7
T = [
    [
        [
            [0] for _z in range(z)
        ] for _y in range(y)
    ] for _x in range(x)
]

for _x in range(x):
    for _y in range(y):
        for _z in range(z):
            T[_x][_y][_z] = randint(10, 99)
maxi = 0
koord = (0, 0, 0)
for _x in range(x):
    for _y in range(y):
        for _z in range(z):
            if T[_x][_y][_z] > maxi:
                maxi = T[_x][_y][_z]
                koord = (_x, _y, _z)

print(*T, sep='\n')
print('==========================')
print(maxi, koord)

