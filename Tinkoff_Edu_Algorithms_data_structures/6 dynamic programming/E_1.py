n, m = map(int, input().split())
n_m = [list()] * n

for i in range(n):
    n_m[i] = [int(x) for x in input().split()[:m]]


def calc(matrix, k, m):
    x, y, p, maxi = 0, 0, 0, 0
    k -= 1
    for i in range(m):
        x = 0
        for j in range(i + 1, m):
            if matrix[k][i] < matrix[k][j]:
                x += 1
            else:
                break
        y = 0
        for j in range(i, -1, -1):
            if matrix[k][i] <= matrix[k][j]:
                y += 1
            else:
                break
        p = matrix[k][i] * (x + 1)
        if p > maxi:
            maxi = p

    return maxi


print(calc(n_m, n, m))