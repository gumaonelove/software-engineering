import random


class Node:
    '''Узел дерева'''

    def __init__(self, value):
        self.value = value # x
        self.left = None
        self.right = None
        self.p = random.random()


def merge(l: Node, r: Node):
    '''Все ключи в l <= ключом r'''
    if l is None:
        return r
    if r is None:
        return l
    if l.p < r.p:
        l.right = merge(l.right, r)
        return l
    else:
        r.left = merge(l, r.left)
        return r

def split(node: Node, value):
    '''Берет поддерево Node и разделяет его на два по ключу x'''
    if node is None:
        return None, None
    if node.value < value:
        l, r = split(node.right, value)
        node.right = l
        return node, r
    else:
        l, r = split(node.left, value)
        node.left = r
        return l, node


def find(node: Node, value):
    '''Поиск по дереву'''
    if node is None:
        return None
    if node.value == value:
        return node
    elif node.value < value:
        return find(node.right, value)
    elif node.value > value:
        return find(node.left, value)


class Tree:
    '''Декартово дерево'''

    def __init__(self):
        self.root = None

    def add(self, value):
        '''Добавление узла в дерево'''
        if find(self.root, value):
            return None
        l, r = split(self.root, value)
        self.root = merge(merge(l, Node(value)), r)

    def next(self, value):
        '''Вывод минимального элемента, не меньшего value'''
        node: Node = self.root
        last = None
        while node != None:
            # print('node.value =', node.value)
            if node.value >= value:
                last = node.value
                node = node.left
            elif node.value < value:
                node = node.right

        return last if last is not None else -1


n = int(input())
tree = Tree()
last = [None, None]
answer = []
for _ in range(n):
    action, value = str(input()).split(' ')
    if action == '+':
        if last[0] == '?':
            tree.add((int(value) + last[-1]) % 10**9)
        else:
            tree.add(int(value))
        last = ['+', 0]
    elif action == '?':
        _next = tree.next(int(value))
        last = ['?', _next]
        answer.append(_next)

print(*answer, sep='\n')