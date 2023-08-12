letters = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'
answer = []
class Node:
    def __init__(self, data, par=None):
        self.data = list([data])
        self.parent = par
        self.child = list()

    def __str__(self):
        return str(self.data)

    def __lt__(self, node):
        return self.data[0] < node.data[0]

    def _isLeaf(self):
        '''Лист?'''
        return len(self.child) == 0

    def _add(self, new_node):
        '''merge new_node sub-tree into self node'''
        for child in new_node.child:
            child.parent = self
        self.data.extend(new_node.data)
        self.data.sort()
        self.child.extend(new_node.child)
        if len(self.child) > 1:
            self.child.sort()
        if len(self.data) > 2:
            self._split()

    def _insert(self, new_node):
        '''find correct node to insert new node into tree'''
        if self._isLeaf():
            self._add(new_node)

        elif new_node.data[0] > self.data[-1]:
            self.child[-1]._insert(new_node)
        else:
            for i in range(0, len(self.data)):
                if new_node.data[0] < self.data[i]:
                    self.child[i]._insert(new_node)
                    break

    def _split(self):
        '''3 items in node, split into new sub-tree and add to parent'''
        left_child = Node(self.data[0], self)
        right_child = Node(self.data[2], self)
        if self.child:
            self.child[0].parent = left_child
            self.child[1].parent = left_child
            self.child[2].parent = right_child
            self.child[3].parent = right_child
            left_child.child = [self.child[0], self.child[1]]
            right_child.child = [self.child[2], self.child[3]]

        self.child = [left_child]
        self.child.append(right_child)
        self.data = [self.data[1]]

        if self.parent:
            if self in self.parent.child:
                self.parent.child.remove(self)
            self.parent._add(self)
        else:
            left_child.parent = self
            right_child.parent = self

    def _find(self, item):
        '''find an item in the tree; return item, or False if not found'''
        if item in self.data:
            return item
        elif self._isLeaf():
            return False
        elif item > self.data[-1]:
            return self.child[-1]._find(item)
        else:
            for i in range(len(self.data)):
                if item < self.data[i]:
                    return self.child[i]._find(item)

    def _preorder(self, count):
        if len(self.data) == 1:
            answer.append([self.data[0], letters[count]])
        elif len(self.data) == 2:
            answer.append([self.data[0], letters[count]])
            answer.append([self.data[1], letters[count]])
        elif len(self.data) == 3:
            answer.append([self.data[0], letters[count]])
            answer.append([self.data[1], letters[count]])
            answer.append([self.data[2], letters[count]])
        for child in self.child:
            child._preorder(count + 1)


def sort_print(node: Node, count: int):
    '''
    Печать дерева в отсортированном порядке
    node - узел в дереве
    count - этаж
    '''
    while len(node.child) != 0:
        node = node.child[0]
        count += 1
    print('sort_print', node, 'level =', letters[count]) # Самый малый элемент дерева


class Tree:
    def __init__(self):
        self.root = None

    def insert(self, item):
        if self.root is None:
            self.root = Node(item)
        else:
            self.root._insert(Node(item))
            while self.root.parent:
                self.root = self.root.parent
        return True

    def find(self, item):
        return self.root._find(item)

    def remove(self, item):
        self.root.remove(item)

    def preorder(self):
        self.root._preorder(0)


tree = Tree()

n = int(input())
lst = [tree.insert(int(x)) for x in input().split()]

tree.preorder()
answer = sorted(answer, key=lambda key: key[0])
_str = ''

for item in answer:
    _str += str(item[0]) + ' ' + item[1] + ' '

print(_str[:-3])