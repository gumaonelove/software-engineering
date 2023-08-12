n, m = map(int, input().split())

n_m = [list()] * n
dp_j = [list()] * n
dp_i = [list()] * n

max_len, l, r = -1, 0, 0
all_none_i, all_none_j = True, True

for i in range(n):
    n_m[i] = [int(x) for x in input().split()[:m]]
    dp_j[i] = [0] * m
    dp_i[i] = [0] * m

for i in range(n - 1, -1, -1):
    for j in range(m - 1, -1, -1):
        if j == m - 1:
            if n_m[i][j]:
                dp_j[i][j] = None
            else:
                all_none_j = False
                dp_j[i][j] = m - 1
        else:
            if n_m[i][j] == 1:
                dp_j[i][j] = dp_j[i][j + 1]
            else:
                dp_j[i][j] = j


for j in range(m - 1, -1, -1):
    for i in range(n - 1, -1, -1):
        if i == n - 1:
            if n_m[i][j]:
                dp_i[i][j] = None
            else:
                all_none_i = False
                dp_i[i][j] = n - 1
        else:
            if n_m[i][j] == 1:
                dp_i[i][j] = dp_i[i + 1][j]
            else:
                dp_i[i][j] = i


for i in range(n):
    for j in range(m):
        if n_m[i][j] == 1 and dp_j[i][j] == dp_i[i][j]:
            if (dp_j[i][j] is not None) and dp_j[i][j] - i > max_len:
                max_len = dp_j[i][j] - i
                l, r = i, j


if all_none_i and all_none_j:
    print(min(m, n))
    print(1, 1)
else:
    #print(*n_m, sep='\n')
    #print('##########')
    #print(*dp_j, sep='\n')
    #print('##########')
    #print(*dp_i, sep='\n')
    #print('###########')
    print(max_len)
    print(l + 1, r + 1)
