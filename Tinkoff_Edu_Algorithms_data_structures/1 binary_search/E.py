'''Дано кубическое уравнение.
Известно, что у этого уравнения ровно один корень. От вас требуется его найти.
Заметьте, что разрешены различные случаи: любой из коэффициентов может быть положительным, отрицательным,
или все коэффициенты, кроме a, могут быть равны нулю.'''

a, b, c, d = map(int, input().split())


def condition(a, b, c, d, x):
    return a * (x ** 3) + b * (x ** 2) + c * x + d


def binary_search(a, b, c, d):
    r = 1

    while condition(a, b, c, d, r) * condition(a, b, c, d, -r) >= 0:
        r *= 2

    l = -r

    while r - l > 10 ** (-4):
        x = (l + r) / 2
        if condition(a, b, c, d, x) * condition(a, b, c, d, r) > 0:
            r = x
        else:
            l = x

    print(l)


binary_search(a, b, c, d)
# -1000 -1000 -1000 -1000