maxn = 10 ** 5 + 5
k = 3
mod = 10 ** 9 + 7

p = [1] * maxn

for i in range(1, maxn):
    p[i] = (111 * p[i-1] * k) % mo # аккуратно с переполнением
    

h = [0] * maxn

#будем считать, что s это уже последовательность int-ов
s = str(input())
l_s = len(s)


for i in range(l_s):
    h[i+1] = (h[i] + p[i] * ord(s[i])) % mod
    
def hash_substring(l, r):
    return (h[r + 1] - h[ l ]) * p[l_s - l] % mod



m = int(input())
for _ in range(m):
    a, b, c, d = map(int, input().split())
    a, b, c, d = a - 1, b - 1, c - 1, d - 1
    if b - a == d - c:
        if hash_substring(a, b) == hash_substring(c, d):
            print('Yes')
        else:
            print('No')
    else:
        print('No')