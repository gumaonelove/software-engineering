# by Manacher's algorithm
def count_palindromes(ss):
    s = "$#" + "#".join(ss) + "#"
    n = len(s)
    p = [0] * n
    l, r = 0, -1
    for i in range(n):
        k = 1 if i > r else min(p[l + r - i], r - i + 1)
        while i + k < n and i - k >= 0 and s[i + k] == s[i - k]:
            k += 1
        p[i] = k
        if i + k - 1 > r:
            l = i - k + 1
            r = i + k - 1
    return sum([x // 2 for x in p])


print(count_palindromes(input()))