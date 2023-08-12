n, m = map(int, input().split())  # n - str, m - col

board = []

for i in range(n):
    board.append([-1] * m)

board[0][0] = 1


def calc(i, j):
    global board
    if 0 <= i < n and 0 <= j < m:
        if board[i][j] == -1:
            board[i][j] = calc(i + 1, j - 2) + calc(i - 1, j - 2) + calc(i - 2, j + 1) + calc(i - 2, j - 1)
        return board[i][j]

    return 0


calc(n - 1, m - 1)
print(board[-1][-1])
