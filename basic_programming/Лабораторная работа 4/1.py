'''
Задание 1
Задан граф в виде количества вершин n<=10 и последовательности ребер
(каждое ребро задается парой смежных вершин).
Получить матрицу смежности.
а) Напечатать матрицу смежности. Проверить, есть ли в графе петли. done
б) Напечатать матрицу смежности. Проверить, есть ли в графе вершины, не смежные с другими. done
в) Напечатать для каждой вершины номера смежных вершин. done
г) Проверить, есть ли в графе вершина, смежная со всеми другими вершинами. done
д) Определить степень каждой вершины графа. done
е) Напечатать номера вершин со степенью 1. done
ж) Определить степень графа (максимальную степень его вершин). done
'''

n = int(input('n = ')) # Количество вершин графа
E = [] # Список ребер графа
V = set() # Список вершин графа


def get_adjacency_matrix(E, V, n):
    '''
    Создадим матрицу смежности
    :param E: Список ребер
    :param V: Список вершин (составленный из ребер поданных на вход)
    :param n: Количество вершин заданное пользователем
    :return: Матрица смежности
    '''

    M = [] # Матрица смежности
    cycle = False # Есть ли циклы
    island = False # Есть ли островная вершина
    friends = {} # Смежные вершины для каждой вершины
    connected_with_all = False # Есть ли смежная со всеми вершина
    degrees_of_vertices = {} # Степени для каждой вершины
    max_degree = 0 # Максимальная степень вершины
    one_degree = [] # Вершины со степенью 1

    for i in range(n):
        M.append([0] * n)
        friends[i] = set()

    for e0, e1 in E:
        if e0 == e1:
            M[e0][e1] += 1
            cycle = True
        else:
            M[e0][e1] += 1
            M[e1][e0] += 1

        friends[e0].add(e1)
        friends[e1].add(e0)

        if sum(M[e0]) == n-1: connected_with_all = True

    for friend in friends:
        degrees_of_vertices[friend] = len(friends[friend])
        if len(friends[friend]) > max_degree: max_degree = len(friends[friend])

    for friend in friends:
        if len(friends[friend]) == 1: one_degree.append(friend)

    if len(V) != n:
        island = True

    answer = {
        'M': M,
        'cycle': cycle,
        'island': island,
        'friends': friends,
        'connected_with_all': connected_with_all,
        'degrees_of_vertices': degrees_of_vertices,
        'max_degree': max_degree,
        'one_degree': one_degree
    }
    return answer

try:
    while True:
        a, b = map(int, input('Введите ребро: ').split())
        E.append((a, b))
        V.add(a); V.add(b)
except:
    print('Ввод графа закончен\n')
finally:
    G1 = get_adjacency_matrix(E, V, n)
    print('Список ребер графа: {}'.format(E))
    print('Список вершин графа: {}'.format([int(x) for x in range(n)]))
    print('Матрица смежности:')
    print(*G1['M'], sep='\n')
    print('Есть ли циклы в графе: {}'.format(G1['cycle']))
    print('Есть ли вершины не связанные ни с кем: {}'.format(G1['island']))
    print('Смежные вершины для каждой вершины: {}'.format(G1['friends']))
    print('Смежные со всеми остальными: {}'.format(G1['connected_with_all']))
    print('Степени вершин: {}'.format(G1['degrees_of_vertices']))
    print('Максимальная степень вершины: {}'.format(G1['max_degree']))
    print('Вершины со степенью 1: {}'.format(G1['one_degree']))