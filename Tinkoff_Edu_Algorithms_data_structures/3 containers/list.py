class List:
    '''Направленный список'''
    def __init__(self, val):
        self.val = val
        self.next = None

    def insert(self, node):
        node.next = self.next
        self.next = node