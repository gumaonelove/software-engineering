def has_cycle(graph):
    def dfs(v):
        visited[v] = 1
        for u in graph[v]:
            if visited[u] == 0:
                if dfs(u):
                    return True
            elif visited[u] == 1:
                return True
        visited[v] = 2
        return False

    for v in range(1, n+1):
        if visited[v] == 0:
            if dfs(v):
                return True
    return False


n, m = map(int, input().split())
graph = {i: set() for i in range(1, n+1)}
visited = [0] * (n+1)


for i in range(m):
    u, v = map(int, input().split())
    graph[u].add(v)


print(int(has_cycle(graph)))