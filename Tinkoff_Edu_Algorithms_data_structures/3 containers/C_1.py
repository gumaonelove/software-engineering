class Queue:
    '''Очередь на основе динамического массива'''

    def __init__(self, size: int):
        self.data = [None] * size
        self.head = 0
        self.tail = 0

    def push(self, x):
        self.data[self.tail] = x
        self.tail += 1

    def pop(self):
        if self.head == self.tail:
            return None
        res = self.data[self.head]
        self.data[self.head] = None
        self.head += 1
        return res

    def show(self):
        return (self.data)


n = int(input())
first = Queue(n)
stop_arr = [0] * n
second = [0] * n

for wagon in input().split(' '):
    first.push(int(wagon))

stop = -1
next = 0
count = 1
answer = []

while (n != next) or (stop != -1 and stop_arr[stop] != count):
    if stop != -1 and stop_arr[stop] != count:
        stop -= 1
        count += 1
        answer.append(1)
    else:
        stop += 1
        stop_arr[stop] = second[next]
        next += 1
        answer.append(2)

if count == n + 1:
    print(answer)
else:
    print(0)