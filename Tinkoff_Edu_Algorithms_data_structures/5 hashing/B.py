s = str(input())
t = str(input())

s_l, t_l = len(s), len(t)
p = [1] * (s_l + 1)
k = 31
mod = 10 ** 9 + 7

for i in range(1, s_l + 1):
    p[i] = (111 * p[i - 1] * k) % mod

hs = [ord(s[0])] * (s_l + 1)
for i in range(1, s_l):
    hs[i] = (hs[i - 1] + p[i] * ord(s[i])) % mod

ht = ord(t[0])
for i in range(1, t_l):
    ht += (p[i] * ord(t[i])) % mod


def get_hash(h: list, l: int, r: int):
    '''Вычисляем хэш подстроки'''
    result = h[r]
    if l > 0:
        result -= h[l - 1]
    return result % mod


answer = []

for i in range(0, s_l - t_l + 1):
    if get_hash(hs, i, i + t_l - 1) == (ht * p[i]) % mod:
        answer.append(i)

print(*answer)