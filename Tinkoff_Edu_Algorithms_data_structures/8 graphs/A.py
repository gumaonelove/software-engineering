'''
Дан неориентированный невзвешенный граф. 
Необходимо посчитать количество его компонент связности и вывести их.

Формат вывода
В первой строчке выходного файла выведите количество компонент связности. 
Далее выведите сами компоненты связности в следующем формате: в первой строке 
количество вершин в компоненте, во второй - сами вершины в отсортированном порядке
'''

import sys

sys.setrecursionlimit(150000)


def dfs(v):
    visited.add(v)
    component.append(v)
    for u in graph[v]:
        if u not in visited:
            dfs(u)

n, m = map(int, input().split())
graph = {i: set() for i in range(1, n+1)}
for i in range(m):
    u, v = map(int, input().split())
    graph[u].add(v)
    graph[v].add(u)

visited = set()
components = []
for v in range(1, n+1):
    if v not in visited:
        component = []
        dfs(v)
        components.append(component)

print(len(components))
for component in components:
    print(len(component))
    print(*sorted(component))
