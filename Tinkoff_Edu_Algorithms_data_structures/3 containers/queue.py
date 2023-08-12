class Queue:
    '''Очередь на основе динамического массива'''

    def __init__(self):
        self.data = []
        self.head = 0
        self.tail = 0
        self.size = 0

    def push(self, x):
        if self.tail == self.size:
            self.data += [None] * max(1, self.size)
            self.size = max(1, self.size * 2)
        self.data[self.tail] = x
        self.tail += 1

    def pop(self):
        if self.head == self.tail:
            return None
        res = self.data[self.head]
        self.head += 1
        return res