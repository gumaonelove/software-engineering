from C import main


def test_1():
    p = 'aaaa'
    t = 'Caaabdaaaa'
    assert main(p, t) == (4, '1 2 6 7')


def test_2():
    p = 'a'
    t = 'aaa'
    assert main(p, t) == (3, '1 2 3')


def test_3():
    p = 'a'
    t = 'bbb'
    assert main(p, t) == (3, '1 2 3')


def test_3__1():
    p = 'a'
    t = 'bab'
    assert main(p, t) == (3, '1 2 3')


def test_4():
    p = 'aaaa'
    t = 'baaa'
    assert main(p, t) == (1, '1')


def test_5():
    p = 'aaaa'
    t = 'abaa'
    assert main(p, t) == (1, '1')


def test_6():
    p = 'aaaa'
    t = 'aaba'
    assert main(p, t) == (1, '1')


def test_7():
    p = 'aaaa'
    t = 'aaab'
    assert main(p, t) == (1, '1')


def test_8():
    p = 'aaa'
    t = 'aba'
    assert main(p, t) == (1, '1')