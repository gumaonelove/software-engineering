from openpyexcel import load_workbook


def __read_file():
    '''
    Читаем файл excel
    :return: содержимое листа
    '''
    wb = load_workbook(filename='map.xlsx', read_only=True)
    ws = wb['Sheet1']
    return ws


def __get_graph():
    '''
    :return: возвращаем неориентированный взвешенный граф
    '''
    ws = __read_file()

    inf = float('Inf')
    _len = -1
    for row in ws.rows: _len += 1

    G = [[inf] * _len for _ in range(_len)]

    i, j = 0, 0
    for row in ws.rows:
        for cell in row:
            if cell.value and i and j:
                G[i-1][j-1] = cell.value
                G[j-1][i-1] = cell.value
            j += 1
        i += 1
        j = 0
    return G


def get_list_address():
    '''
    :return: Список возможных адресов
    '''
    ws = __read_file()
    _list = []
    for row in ws.rows:
        for address in row:
            if address.value:
                _list.append(address.value)
        break
    return _list


def __dijkstra(G, start):
    '''
    Алгоритм Дейкстреры
    :param G: Взвешенный граф заданный матрицей смежности
    :param start: Вершина старта
    :return: Массив кротчайших расстояний от старта до указанной вершины
    '''
    n = len(G) # колво вершин графа
    Q = [(0, start)] # очередь
    inf = float('Inf') # бесконечность
    d = [inf for _ in range(n)] # массив кратчайших расстояний
    d[start] = 0

    while len(Q):
        (cost, u) = Q.pop()
        for v in range(n):
            if d[v] > d[u] + G[u][v]:
                d[v] = d[u] + G[u][v]
                Q.append((d[v], v))
    return d


def __get_id_address(start_point, finish_point):
    addresses = get_list_address()
    start_index = addresses.index(start_point)
    finish_index = addresses.index(finish_point)

    return start_index, finish_index


def __get_path(start, finish):
    '''
    Восстанавливаем кратчайший путь
    :param start: старт id
    :param finish: финиш id
    :return: путь
    '''
    G = __get_graph()
    d = __dijkstra(G, start)
    n = len(G)
    path = [finish]
    f = finish
    while finish != start:
        for v in range(n):
            if d[v] == d[finish] - G[finish][v]:
                path.append(v)
                finish = v
    return path[::-1], d[f]


def get_beautiful_path(start_address, finish_address):
    ''''''
    start, finish = __get_id_address(start_address, finish_address)
    path, module = __get_path(start, finish)
    beautiful = ''
    addresses = get_list_address()
    for point in path:
        beautiful += addresses[point] + ' --> '
    return beautiful[:-5], module