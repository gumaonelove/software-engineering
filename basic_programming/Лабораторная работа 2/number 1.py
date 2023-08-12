'''
Вычислите сумму ряда
'''


def eight_example(x, N):
    '''8 вариант'''
    suma = 1
    _1 = -1
    _x = 1
    _n = 1

    for n in range(1, N+1):
        suma += (_1 * _x) / _n
        _1 *= -1
        _x *= x ** 2
        _n *= n

    return suma


x=int(input('x: '))
N=int(input('n: '))

print(eight_example(x, N))