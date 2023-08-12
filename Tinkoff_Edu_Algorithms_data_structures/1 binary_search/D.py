'''Найдите такое число x, что x**2 + (x+1)**0.5 = C'''


def condition(x):
    return x ** 2 + (x+1) ** 0.5


def binary_search(c):
    left = 0
    right = c
    x = (left + right) ** 0.5

    while abs(condition(x) - c) > 10 ** (-6):
        if condition(x) >= c:
            right = x
        else:
            left = x
        x = (left + right) / 2

    print(x)


binary_search(float(input()))