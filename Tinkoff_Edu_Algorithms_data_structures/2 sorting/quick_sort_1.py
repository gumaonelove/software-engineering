n = int(input())
nums = list(range(1, n + 1))[::-1]
B = [0] * n


def quick_sort(nums, left, right):
    if right <= left:
        return
    index, i, j = (left + right) // 2, left, right
    q = nums[index]

    while i <= j:
        while nums[i] < q:
            i += 1
        while q < nums[j]:
            j -= 1
        if i <= j:
            nums[i], nums[j] = nums[j], nums[i]
            i += 1
            j -= 1
    quick_sort(nums, left, j)
    quick_sort(nums, i, right)



quick_sort(nums, 0, n - 1)
