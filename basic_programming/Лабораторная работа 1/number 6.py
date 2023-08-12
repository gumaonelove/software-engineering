'''
6) Дано трехзначное число. Вывести число, полученное при прочтении исходного числа справа налево.
'''

def first_way(n):
    '''reverse the string'''
    return str(n)[::-1]

def second_way(n):
    '''with division'''
    ans, n = '', int(n)
    while n != 0:
        ans += str(n%10)
        n //= 10
    return ans


print(f'Перевернутое число = {first_way(int(input("Введите число: ")))}')