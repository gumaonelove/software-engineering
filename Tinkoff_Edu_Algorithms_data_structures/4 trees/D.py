class Node:
    '''Узел декартова дерева'''

    def __init__(self, key: int):
        self.key, self.min, self.max = key, key, key
        self.suma, self.height = 0, 1
        self.left, self.right = None, None

    def get_height_left(self) -> int:
        '''left'''
        if self.left is None: return 0
        return self.left.height

    def get_height_right(self) -> int:
        '''right'''
        if self.right is None: return 0
        return self.right.height

    def get_balance(self) -> int:
        '''balancing'''
        return self.get_height_right() - self.get_height_left()

    def get_sum_left(self) -> int:
        '''left suma'''
        if self.left: return self.left.suma
        return 0

    def get_sum_right(self) -> int:
        '''right suma'''
        if self.right: return self.right.suma
        return 0

    def get_min_left(self) -> float:
        '''min from left tree'''
        if self.left: return self.left.min
        return float('inf')

    def get_min_right(self) -> float:
        '''min from right tree'''
        if self.right: return self.right.min
        return float('inf')

    def get_max_left(self) -> float:
        '''max from left tree'''
        if self.left: return self.left.max
        return float('-inf')

    def get_max_right(self) -> float:
        '''max from right tree'''
        if self.right: return self.right.max
        return float('-inf')

    def recalc_min_max(self) -> None:
        '''recalc min and max'''
        self.min = min(self.get_min_right(), self.get_min_left(), self.key)
        self.max = max(self.get_max_right(), self.get_max_left(), self.key)

    def recalc_sum(self) -> None:
        '''recalc suma'''
        self.suma = self.get_sum_left() + self.get_sum_right()
        if self.left: self.suma += self.left.key
        if self.right: self.suma += self.right.key

    def recalc_height(self) -> None:
        '''recalc height'''
        self.height = 1 + max(self.get_height_left(), self.get_height_right())

    def recalc(self) -> None:
        '''all recalc'''
        self.recalc_height()
        self.recalc_sum()
        self.recalc_min_max()


def find(node: Node, x: int) -> Node:
    '''Поиск по дереву'''
    if (node is None) or (node.key == x):
        return node
    elif node.key < x:
        return find(node.right, x)
    elif node.key > x:
        return find(node.left, x)


def exists(node: Node, value: int) -> bool:
    '''bool find'''
    return find(node, value) is not None


def right_rotate(node: Node) -> Node:
    '''Поворот дерева в право'''
    left = node.left
    node.left = left.right
    left.right = node

    node.recalc()
    left.recalc()
    return left


def left_rotate(node: Node) -> Node:
    '''Поворот дерева в лево'''
    right = node.right
    node.right = right.left
    right.left = node

    node.recalc()
    right.recalc()
    return right


def re_balance(node: Node) -> Node:
    '''Ре-балансировка дерева'''
    if node.get_balance() == 2:
        if node.right.get_balance() < 0: node.right = right_rotate(node.right)
        return left_rotate(node)
    if node.get_balance() == -2:
        if node.left.get_balance() > 0: node.left = left_rotate(node.left)
        return right_rotate(node)
    return node


def insert(node: Node, new_key: int) -> Node:
    '''Добавление нового ключа'''
    if node is None: return Node(new_key)

    if new_key < node.key:
        node.left = insert(node.left, new_key)
    else:
        node.right = insert(node.right, new_key)

    node.recalc()
    return re_balance(node)


def insert_node(node: Node, new_key: int) -> Node:
    '''Вставка новой вершины'''
    if exists(node, new_key): return node
    return insert(node, new_key)


def suma(node: Node, l: int, r: int) -> int:
    '''Сумма'''
    if node is None: return 0
    if node.key > r: return suma(node.left, l, r)
    if node.key < l: return suma(node.right, l, r)
    if node.left is None and node.right is None: return node.key
    if node.min >= l and node.max <= r: return node.suma + node.key

    return suma(node.left, l, r) + suma(node.right, l, r) + node.key


root = None
prev = '+'
res = 0
n = int(input())
answer = []

for _ in range(n):
    _str = str(input()).split(' ')

    if _str[0] == '+':
        x = int(_str[1])
        if prev == '?':
            root = insert_node(root, (x + res) % (10 ** 9))
        else:
            root = insert_node(root, x)
    else:
        l, r = int(_str[1]), int(_str[2])
        res = suma(root, l, r)
        answer.append(res)
    prev = _str[0]


print(*answer, sep='\n')