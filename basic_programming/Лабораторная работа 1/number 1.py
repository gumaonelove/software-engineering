'''
1) Даны катеты прямоугольного треугольника a и b. Найти его гипотенузу c и периметр P.
'''


def get_hypotenuse(a, b):
    '''Используя теорему пифагора рассчитаем катет'''
    return (a ** 2 + b ** 2) ** 0.5


def perimeter(a, b, c):
    '''Рассчитаем периметр треугольника'''
    return a + b + c


a, b = float(input('Введите длину первого катета: ')), float(input('Введите длину второго катета: '))

c = get_hypotenuse(a, b)

print(f'Гипотенуза вашего треугольника = {c}')
print(f'Периметр вашего треугольника = {perimeter(a, b, c)}')