import re
import sys


def change(s: str) -> str:
    res = re.sub(r"cl", 's', s)
    res = re.sub(r"Cl", 's', res)
    res = re.sub(r"cL", 's', res)
    res = re.sub(r"CL", 's', res)

    res = re.sub(r"ce", 's', res)
    res = re.sub(r"ck", '', res)
    res = re.sub(r"c", 'k', res)

    res = re.sub(r"ee", 'i', res)
    res = re.sub(r"oo", 'U', res)
    res = re.sub(r'(\w)\1', r'\1', res)
    return res


if __name__ == '__main__':
    for line in sys.stdin:
        res = change(line)
        print(res, end='')