'''
2) Даны два круга с общим центром и радиусами R1 и R2 (R1 > R2). Найти площади этих кругов S1 и S2, а также площадь
S3 кольца, внешний радиус которого равен R1, а внутренний радиус равен R2.
'''
from math import pi


def area(r):
    '''Расчет площади круга'''
    return pi*r**2


def ring(a1, a2):
    '''Площадь кольца'''
    return a1 - a2


area_1, area_2 = area(float(input('Введите первый радиус: '))), area(float(input('Введите первый радиус: ')))

print(f'Площадь 1 круга = {area_1}')
print(f'Площадь второго круга = {area_2}')
print(f'Площадь кольца = {ring(area_1, area_2)}')

