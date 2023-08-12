import random


def sizeof(_tree):
    return _tree.size if _tree else 0


class Node:
    '''Узел дерева'''

    def __init__(self, value: int):
        self.value = value # x
        self.left = None
        self.right = None
        self.p = random.random()
        self.size = 1

    def recalc(self):
        '''Пересчет количества элементов в поддереве'''
        self.size = sizeof(self.left) + sizeof(self.right) + 1

    def __str__(self):
        return f'''
        ########################################
        value = {self.value}, size = {self.size}
        left = {(self.left.value, self.left.size) if self.left else None}
        right = {(self.right.value, self.right.size) if self.right else None}
        ########################################
        '''


def merge(l: Node, r: Node) -> Node:
    '''Все ключи в l <= ключом r'''
    if l is None: return r
    if r is None: return l

    if l.p < r.p:
        l.right = merge(l.right, r)
        answer = l
    else:
        r.left = merge(l, r.left)
        answer = r

    answer.recalc()
    return answer


def split(node: Node, value: int) -> tuple:
    '''Берет поддерево Node и разделяет его на два по ключу x'''
    if node is None:
        return None, None
    if node.value < value:
        l, r = split(node.right, value)
        node.right = l
        node.recalc()
        return node, r
    else:
        l, r = split(node.left, value)
        node.left = r
        node.recalc()
        return l, node


def find(node: Node, value: int):
    '''Поиск по дереву'''
    if node is None: return None
    if node.value == value: return node
    elif node.value < value: return find(node.right, value)
    elif node.value > value: return find(node.left, value)


class Tree:
    '''Декартово дерево'''

    def __init__(self):
        self.root = None

    def add(self, value: int):
        '''Добавление узла в дерево'''
        if find(self.root, value):
            return None
        l, r = split(self.root, value)
        self.root = merge(merge(l, Node(value)), r)
        # print(self.root)

    def remove(self, value):
        l1, r1 = split(self.root, value)
        l2, r2 = split(r1, value + 1)
        self.root = merge(l1, r2)

    def get(self, k) -> int:
        '''Вывод K_i максимума'''
        node: Node = self.root
        while node is not None:
            if sizeof(node.right) == k - 1:
                return node.value

            if sizeof(node.right) >= k:
                node = node.right
            else:
                k -= sizeof(node.right) + 1
                node = node.left


n = int(input())
tree = Tree()
answer = []
for _ in range(n):
    action, value = str(input()).split(' ')
    if action == '-1':
        tree.remove(int(value))
    elif action == '0':
        answer.append(tree.get(int(value)))
    else:
        tree.add(int(value))


print(*answer, sep='\n')