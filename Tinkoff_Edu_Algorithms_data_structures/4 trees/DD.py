import random


class Node:
    '''Узел дерева'''

    def __init__(self, value):
        self.value = value # x
        self.left = None
        self.right = None
        self.p = random.random()


def merge(l: None, r: None):
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


def split(node: Node, x):
    '''Берет поддерево Node и разделяет его на два по ключу x'''
    if node is None:
        return None, None
    if node.value < x:
        l, r = split(node.right, x)
        node.right = l
        return node, r
    else:
        l, r = split(node.left, x)
        node.left = r
        return l, node


def find(node: Node, x):
    '''Поиск по дереву'''
    if node is None:
        return None
    if node.value == x:
        return node
    elif node.value < x:
        return find(node.right, x)
    elif node.value > x:
        return find(node.left, x)


class Tree:
    '''Декартово дерево'''

    def __init__(self):
        self.root = None

    def insert(self, value):
        if find(self.root, value):
            return None
        l, r = split(self.root, value)
        self.root = merge(merge(l, Node(value)), r)

    def remove(self, value):
        l1, r1 = split(self.root, value)
        l2, r2 = split(r1, value + 1)
        self.root = merge(l1, r2)

    def contains(self, value):
        return find(self.root, value) is not None