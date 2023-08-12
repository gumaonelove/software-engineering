from random import randint


def get_list(start, step, count):
    g_list = []
    while len(g_list) != count:
        g_list.append(randint(start, step))

    return list(g_list)


def get_set(start, step, count):
    g_set = set()
    while len(g_set) != count:
        g_set.add(randint(start, step))

    return list(g_set)