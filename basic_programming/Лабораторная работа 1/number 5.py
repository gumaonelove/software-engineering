'''
5) Дано трехзначное число. Найти сумму и произведение его цифр.
'''

def answer(n):
    '''Вернем сумму и произведение цифр'''
    number = {'sum': 0, 'work': 1}
    while n != 0:
        number['sum'] += n%10
        number['work'] *= n%10
        n //= 10
    return number


number = answer(int(input('Введите число: ')))

print(f"Сумма цифр: {number['sum']} \nПроизведение цифр: {number['work']}")
