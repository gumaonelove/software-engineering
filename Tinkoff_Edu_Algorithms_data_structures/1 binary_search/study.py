arr = list(map(int, input().split()))

left = -1
right = len(arr)

while left + 1 < right:
    m = (left + right) // 2
    if arr[m] == 0:
        left = m
    else:
        right = m

print(right)