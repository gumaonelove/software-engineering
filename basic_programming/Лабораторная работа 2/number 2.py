help_text = '''Задание 2. Пользователь вводит с клавиатуры любую фразу (от 10 символов). Используя срезы выведите на экран:
а) первые 4 символа,
б) последние 4 символа
в) символ посередине,
г) символы с 3-го по 8-й.
'''


def main_script(string, variant):
    '''Коммент'''
    if variant == 'а':
        return string[:4]
    elif variant == 'б':
        return string[-4:]
    elif variant == "в":
        return string[len(string)//2]
    elif variant == 'г':
        return string[2:8]
    else:
        return 'Выберите корректный вариант'


def second_script(string):
    '''Коммент'''
    return [
        ("а:", string[:4]),
        ("б:", string[-4:]),
        ("в:", string[len(string)//2]),
        ("г:", string[2:8])
         ]


print(help_text)


_str = input('Фраза: ')

if len(_str) >= 10:
    print(*second_script(_str), sep='\n')
else:
    print('Ошибка, любая фраза от 10 символов!')