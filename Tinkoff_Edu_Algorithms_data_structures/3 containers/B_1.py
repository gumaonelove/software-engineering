from collections import deque


def main(A, k, n):
    mins = []
    deq = deque()
    counter = 0
    for i in range(n):
        if (counter > 0) and (deq[0] <= i - k):
            deq.popleft()
            counter -= 1
        while counter > 0 and (A[deq[-1]] >= A[i]):
            deq.pop()
            counter -= 1

        deq.append(i)
        counter += 1

        if i >= k - 1:
            mins.append(A[deq[0]])

    return mins


N, K = list(map(int, input().split()))
A = list(map(int, input().split()))
print(*main(A, K, N))