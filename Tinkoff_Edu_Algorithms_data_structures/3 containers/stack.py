class Stack:
    '''Стэк на основе динамического массива'''
    def __init__(self):
        self.size, self.end = 1, 0
        self.data = [None] * self.size

    def push(self, x):
        if self.end == self.size:
            self.data += [None] * self.size
            self.size *= 2
        self.data[self.end] = x
        self.end += 1

    def pop(self):
        self.end -= 1
        return self.data[self.end]

    def show(self):
        print(self.data)