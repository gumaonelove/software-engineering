n = int(input())

nums = [int(x) for x in input().split()[:n]]
if n > 2:
    dp = [nums[0], nums[1]] + [0] * (n - 2)

    for i in range(2, n):
        dp[i] += min(dp[i - 2], dp[i - 1]) + nums[i]

    print(dp[-1])
else:
    print(nums[-1])