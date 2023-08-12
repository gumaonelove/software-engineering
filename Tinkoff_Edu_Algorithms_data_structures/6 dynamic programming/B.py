n = int(input())
counts = [1, 3] + [0] * 19

for i in range(2, n+1):
    counts[i] = 2 * (counts[i-1] + counts[i-2])

print(counts[n])