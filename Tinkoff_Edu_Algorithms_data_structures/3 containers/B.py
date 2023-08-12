# Минимум на отрезке

N, K = map(int, input().split())
A = [int(x) for x in input().split()[:N]]
B, C = [10 ** 5 + 1] * N, [10 ** 5 + 1] * N


def build(K):
    global N, B, C, A

    K -= 1

    for i in range(N):
        if i % K:
            B[i] = min(A[i], B[i - 1])
        else:
            B[i] = A[i]

    for i in range(N - 2, -1, -1):
        if (i + 1) % K:
            C[i] = min(A[i], C[i + 1])
        else:
            C[i] = A[i]


def get_min(l):
    return min(C[l], B[l + K - 1])


if K == 1:
    print(1)
else:
    build(K)
    mins = [10 ** 5 + 1] * (N - K + 1)

    for l in range(N - K + 1):
        mins[l] = get_min(l)

    print(*mins)