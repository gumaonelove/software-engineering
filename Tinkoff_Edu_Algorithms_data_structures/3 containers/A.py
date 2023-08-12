# Постфиксная запись
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

    def answer(self):
        print(self.data[0])


def calc(_operator_1, _operator_2, _operand):
    if _operand == '+':
        return _operator_1 + _operator_2
    elif _operand == '-':
        return _operator_1 - _operator_2
    else:
        return _operator_1 * _operator_2


_arr = str(input()).strip().split(' ')
operands = Stack()
operators = Stack()
_operators = ['+', '-', '*']


for item in _arr:
    if item in _operators:
        operands_2 = operands.pop()
        operands_1 = operands.pop()
        operands.push(int(calc(operands_1, operands_2, item)))
    else:
        operands.push(int(item))


operands.answer()