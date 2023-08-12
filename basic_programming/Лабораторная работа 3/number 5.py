'''
Задание 5. Варианты заданий на матрицы.

8. Ввести с помощью генератора случайных чисел вещественную матрицу размерности n×m (заданы константами).
Вычислить среднее арифметическое для каждой строки. Вывести исходную матрицу и полученные значения на экран.
'''
from random import randint

n, m = map(int, input().split())

Matrix = [[0]*m for _ in range(n)]
Sred = []
for i in range(n):
    for j in range(m):
        Matrix[i][j]=randint(10, 99)
    Sred.append(sum(Matrix[i])/m)

print(*Matrix, sep='\n')
print('===========================')
print(Sred)
