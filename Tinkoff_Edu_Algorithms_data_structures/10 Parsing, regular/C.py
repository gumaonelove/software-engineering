import re
import sys


REGEX_MASK = r'\\circle\{\((\d+),(\d+)\)'
REGEX_SUB = r'\\circle{(\2,\1)'


def change(line: str) -> str:
    return re.sub(REGEX_MASK, REGEX_SUB, line.strip())


if __name__ == '__main__':
    for line in sys.stdin:
        res = change(line)
        print(res, end='')