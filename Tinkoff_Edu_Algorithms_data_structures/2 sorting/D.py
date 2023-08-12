'''
Недавно Петя достад с полки запылившуюся детскую энциклопедию и прочитал там про метод шифрования, который использовал
сам Леонардо да Винчи. Метод относитлельно прост  — писать зеркально. Ходят слухи, что для этого он просто прикладывал
зеркало к краю страницы и писал, смотря в отражение.
Но Петя знает, что есть строки, которым такое шифрование ничего не сделает. Строка, которая одинаково читаются справа
налево и слева направо называются палиндромами.
У Пети есть обычная строка, состоящая из больших букв латинского алфавита. Ему стало интересно, можно ли составить
из каких-то букв этой строки палиндром. Петя хочет получить палиндром наибольшей длины, а из всех таких  —
первый в алфавитном порядке.
Так как Пете еще надо дочитать энциклопедию, то он попросил сделать это вас.
'''


def _get_alphabet(n: int, N: str) -> list:
    alphabet = {}

    for i in range(n):
        letter = N[i]
        if letter in alphabet:
            alphabet[letter] += 1
        else:
            alphabet[letter] = 1

    alphabet = sorted(alphabet.items(), key=lambda item: item[0])

    return alphabet


def main(n: int, N: str) -> str:
    alphabet = _get_alphabet(n, N)
    center, answer = '', []

    for i in range(len(alphabet)):
        letter, count = alphabet[i]
        if count > 1:
            answer.extend([letter] * (count // 2))
            if count % 2 == 1 and not center:
                center = letter
        elif count == 1 and not center:
            center = letter

    answer = [*answer, center, *answer[::-1]]
    return ''.join(answer)


if __name__ == '__main__':
    n = int(input())
    N = str(input())[:n]

    print(main(n, N))