# Гоблины и очереди

class Node:
    '''Узел связанного списка'''
    def __init__(self, data):
        '''Устанавливает данные в выделенном узле и возвращает их'''
        self.data = data
        self.next = None
        self.before = None


class Queue:
    '''Очередь на основе связанного списка'''
    def __init__(self):
        self.rear = None
        self.front = None
        self.center = None
        self.count = 0

    def pop(self):  # удалить в начале
        '''Вспомогательная функция для удаления переднего элемента из очереди'''
        if self.front is None:
            return None

        temp = self.front
        self.front = self.front.next # продвигает фронт к следующему узлу

        if self.front is None:  # , если список станет пустым
            self.rear = None
            self.center = None

        if self.center == temp:
            self.center = self.front

        if self.count % 2 == 1 and self.center != None:
            self.center = self.center.next

        self.count -= 1
        return temp.data

    def insert(self, item):
        if self.count == 0:
            self.push(item)
        else:
            if self.count % 2 == 1 and self.count != 1:
                self.center = self.center.next
            node = Node(item)
            tmp_node = self.center
            next = self.center.next

            node.before = tmp_node
            node.next = next

            if next != None:
                next.before = node
            else:
                self.rear = node

            tmp_node.next = node
            self.count += 1

    def push(self, item):
        '''Вспомогательная функция для добавления элемента в queue'''
        node = Node(item)  # выделяет узел в куче

        if self.front is None: # Особый случай #: queue пуста
            # инициализирует как передние, так и задние
            self.front = node
            self.center = node
            self.rear = node
        else:  # обновление сзади
            if self.count % 2 == 1 and self.count != 1:
                self.center = self.center.next

            self.rear.next = node
            node.before = self.rear
            self.rear = node

        self.count += 1

    def show(self):
        arr = []
        tmp_node = self.front
        if tmp_node != None:
            arr.append(tmp_node.data)
        for i in range(self.count):
            if tmp_node != None:
                tmp_node = tmp_node.next
            else:
                break
            if tmp_node != None:
                arr.append(tmp_node.data)
            else:
                break
        print('rear =', self.rear.data if self.rear else None, 'queue =', arr, 'center =', self.center.data if self.center else None, 'count =', self.count)


n = int(input())

goblins_queue = Queue()
answer = []

for i in range(n):
    _str = str(input()).split()
    group = _str[0]
    if group == '+':
        index = _str[-1]
        goblins_queue.push(index)
    elif group == '*':
        index = _str[-1]
        goblins_queue.insert(index)
    elif group == '-':
        answer.append(goblins_queue.pop())
    goblins_queue.show()


print(*answer, sep='\n')