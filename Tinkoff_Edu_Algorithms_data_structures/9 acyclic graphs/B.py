def dfs1(v):
    used[v] = True
    for u in g[v]:
        if not used[u]:
            dfs1(u)
    order.append(v)


def dfs2(v):
    used[v] = True
    component.append(v)
    for i in range(len(gr[v])):
        if not used[gr[v][i]]:
            dfs2(gr[v][i])


n, m = map(int, input().split())
g = {verb: [] for verb in range(n)}
gr = {verb: [] for verb in range(n)}
order, component = [], []


for _ in range(m):
    a, b = map(int, input().split())
    g[a-1].append(b-1)
    gr[b-1].append(a-1)

used = [False] * n
for i in range(n):
    if not used[i]:
        dfs1(i)


used = [False] * n
for i in range(n):
    v = order[n-1-i]
    if not used[v]:
        dfs2(v)
        print(component)
        component.clear()