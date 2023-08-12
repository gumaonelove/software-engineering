class Stack:
    '''Стэк на основе динамического массива'''
    def __init__(self, size: int):
        self.end = 0
        self.data = [None] * size

    def push(self, x):
        self.data[self.end] = x
        self.end += 1

    def pop(self):
        self.end -= 1
        res = self.data[self.end]
        self.data[self.end] = None
        return res

    def get(self):
        return self.data[self.end - 1]

    def show(self):
        return (self.data)


class Queue:
    '''Очередь на основе динамического массива'''

    def __init__(self, size: int):
        self.data = [None] * (size + 1)
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

    def get(self):
        return self.data[self.head]

    def show(self):
        return (self.data)


n = int(input())
first = Queue(n)
stop = Stack(n)
second = Stack(n)
counter = 1


def pprint(first_wagon, stop_wagon, counter):
    print('first_wagon', first_wagon)
    print('stop_wagon', stop_wagon)
    print('counter', counter)
    print('first', first.show())
    print('stop', stop.show())
    print('second', second.show())
    print('#########################')


for wagon in input().split(' '):
    first.push(int(wagon))

answer = []
Impossible = False

while second.end != n:
    first_wagon = first.get()
    stop_wagon = stop.get()

    if first_wagon == counter:
        first_wagon = first.pop()
        answer.append(1)
        stop.push(first_wagon)
    elif stop_wagon == counter:
        stop_wagon = stop.pop()
        answer.append(2)
        second.push(stop_wagon)
        counter += 1
    elif first_wagon != None:
        first_wagon = first.pop()
        stop.push(first_wagon)
        answer.append(1)
    else:
        Impossible = True
        break

    #pprint(first_wagon, stop_wagon, counter)

if Impossible:
    print(0)
else:

    count = 0
    last_step = 0
    ans = []
    for step in answer:
        if last_step == 0:
            last_step = step
            count += 1
        else:
            if step == last_step:
                count += 1
                last_step = step
            else:
                ans.append([last_step, count])
                count = 1
                last_step = step
    else:
        ans.append([last_step, count])

    print(len(ans))
    for item in ans:
        print(*item)