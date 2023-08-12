n = int(input())
nums = list(range(1, n + 1))


def not_quick_sort(nums: list) -> None:
    '''Генератор наихудшего случая'''
    for i in range(n):
        nums[i], nums[i // 2] = nums[i // 2], nums[i]

    print(*nums)


not_quick_sort(nums)