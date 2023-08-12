from E import main__1 as main


def test_1():
    n = 3
    A = [1, 2, 3]
    m = 3
    B = [3, 2, 1]
    assert main(n, A, m, B) == 3


def test_2():
    n = 3
    A = [1, 2, 3]
    m = 3
    B = [4, 5, 6]
    assert main(n, A, m, B) == 0


def test_3():
    n = 3
    A = [1, 2, 2]
    m = 3
    B = [1, 1, 2]
    assert main(n, A, m, B) == 2


def test_4():
    n = 3
    A = [1, 1, 1]
    m = 5
    B = [1, 1, 1, 1, 1]
    assert main(n, A, m, B) == 3


def test_5():
    n = 1
    A = [1]
    m = 5
    B = [1, 1, 1, 1, 1]
    assert main(n, A, m, B) == 1


def test_6():
    n = 2
    A = [2, 2]
    m = 1
    B = [2]
    assert main(n, A, m, B) == 1


def test_7():
    n = 6
    A = [5, 1, 2, 2, 3, 4]
    m = 3
    B = [3, 2, 1]
    assert main(n, A, m, B) == 2


def test_8():
    n = 1000
    A = [100_000 for i in range(n)]
    m = 1000
    B = A
    assert main(n, A, m, B) == 1000


def test_9():
    n = 1000
    A = [i for i in range(n)]
    m = 1000
    B = A
    assert main(n, A, m, B) == 1000