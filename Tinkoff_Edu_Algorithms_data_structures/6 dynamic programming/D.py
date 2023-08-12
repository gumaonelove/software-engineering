# https://www.guyrutenberg.com/2008/12/15/damerau-levenshtein-distance-in-python/
def damerau_levenshtein_distance(s1: str, s2: str) -> int:
    d = {}
    len_str1, len_str2 = len(s1), len(s2)

    for i in range(-1, len_str1 + 1):
        d[i, -1] = i + 1
    for j in range(-1, len_str2 + 1):
        d[-1, j] = j + 1

    for i in range(len_str1):
        for j in range(len_str2):
            d[i, j] = min(
                d[i - 1, j] + 1,
                d[i, j - 1] + 1,
                d[i - 1, j - 1] + bool(s1[i] != s2[j])
            )

            if i >= 1 and j >= 1 and s1[i] == s2[j - 1] and s1[i - 1] == s2[j]:
                d[i, j] = min(d[i, j], d[i - 2, j - 2] + 1)

    return d[len_str1 - 1, len_str2 - 1]


if __name__ == '__main__':
    s = str(input())
    t = str(input())
    print(damerau_levenshtein_distance(s, t))