def main(p: str, t: str) -> tuple:
    p_l, t_l = len(p), len(t)
    _pow = [1] * (max(p_l, t_l) + 1)
    k = 31
    mod = 10 ** 9 + 7

    for i in range(1, max(p_l, t_l) + 1):
        _pow[i] = (_pow[i - 1] * k) % mod

    hp = [ord(p[0])] * p_l
    for i in range(1, p_l):
        hp[i] = (hp[i - 1] + _pow[i] * ord(p[i])) % mod

    ht = [ord(t[0])] * t_l
    for i in range(1, t_l):
        ht[i] = (ht[i - 1] + _pow[i] * ord(t[i])) % mod

    def get_hash(h: list, l: int, r: int):
        '''Вычисляем хэш подстроки'''
        result = h[r]
        if l > 0:
            result -= h[l - 1]
        return result % mod

    answer, count = [], 0
    for i in range(t_l - p_l + 1):
        j = 0
        while t[i + j] == p[j]: # Пока j+i и j символы равны # ТУТ МОЖНО БИНАРНЫЙ ПОИСК
            if j == 0 and p_l == 1: # Совпадает первый и единственный символ
                answer.append(str(i + 1))
                count += 1
                break
            if j == p_l - 2:  # Сравниваем ПРЕД последний символ подстроки
                answer.append(str(i + 1))
                count += 1
                break
            j += 1
        else: # мы не в конце строки
            # j и i + j символы НЕ равны
            last_i = i
            i += j
            _p, _t = p[j + 1: p_l], t[i + 1: i + p_l - j]
            _p_hash = get_hash(hp, j + 1, p_l - 1) * _pow[i + 1] % mod
            _t_hash = get_hash(ht, i + 1, i + p_l - j - 1) * _pow[j + 1] % mod
            if _p_hash == _t_hash:
                answer.append(str(last_i + 1))
                count += 1

    return count, ' '.join(answer)


if __name__ == '__main__':
    p = str(input())
    t = str(input())
    count, answer = main(p, t)
    print(count)
    print(answer)