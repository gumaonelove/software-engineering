def get_sum_hash(hash_sum: tuple, num: int) -> tuple:
    mod_1 = 2 ** 64
    mod_2 = 10 ** 9 + 7

    hash_sum = ((hash_sum[0] + (num * 7 * 17) % mod_1) % mod_1,
                (hash_sum[1] * (num * 19 * 29) % mod_2) % mod_2)

    return hash_sum


def main__1(n: int, A: list, m: int, B: list) -> int:
    max_count = 0
    H_i, H_j = [[] for _ in range(n)], [[] for _ in range(m)]

    for s1 in range(n):
        for i in range(n - s1):
            if i == 0:
                H_i[i].append(get_sum_hash((0, 1), A[s1]))
            else:
                H_i[i].append(get_sum_hash(H_i[i - 1][s1], A[s1 + i]))
    for i in range(n):
        H_i[i] = set(H_i[i])

    for s2 in range(m):
        for j in range(m - s2):
            if j == 0:
                hash_b_j = get_sum_hash((0, 1), B[s2])
                H_j[j].append(hash_b_j)
            else:
                hash_b_j = get_sum_hash(H_j[j - 1][s2], B[s2 + j])
                H_j[j].append(hash_b_j)
            if j < n and hash_b_j in H_i[j] and j + 1 > max_count:
                max_count = j + 1
    #print(H_i)
    #print(H_j)
    return max_count


if __name__ == '__main__':
    n = int(input())
    A = [int(x) for x in input().split()[:n]]

    m = int(input())
    B = [int(x) for x in input().split()[:m]]

    print(main__1(n, A, m, B))