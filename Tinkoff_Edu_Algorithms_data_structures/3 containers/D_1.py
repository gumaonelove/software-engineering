import collections


goblins_queue_1 = collections.deque()
goblins_queue_2 = collections.deque()
n = int(input())

for i in range(n):

    _str = input().split()
    group = _str[0]

    if group == '+':
        index = _str[-1]
        goblins_queue_2.append(index)
    elif group == '*':
        index = _str[-1]
        goblins_queue_2.appendleft(index)
    else:
        print(goblins_queue_1.popleft())

    if len(goblins_queue_1) < len(goblins_queue_2):
        goblins_queue_1.append(goblins_queue_2.popleft())