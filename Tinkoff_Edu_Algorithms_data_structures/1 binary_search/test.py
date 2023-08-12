def binary_search(key, N):
    start_element = -1
    end_element = len(N) - 1

    while start_element <= end_element:
        middle_element = (start_element + end_element) // 2

        if N[middle_element] == key:
            return True
        elif N[middle_element] < key:
            start_element = middle_element + 1
        else:
            end_element = middle_element - 1
    return False


arr = list(range(1, 20000, 2))
for i in range(1, 20000):
    if (binary_search(i, arr)) != (i in arr):
        print(i)