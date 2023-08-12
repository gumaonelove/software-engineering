from D import damerau_levenshtein_distance as dld


def test_1():
    assert dld('XABCDE', 'ACBYDF') == 4


def test_2():
    assert dld('HGJIYU', 'SZSH') == 6


def test_3():
    assert dld('geeks', 'forgeeks') == 3


def test_4():
    assert dld('GHDS', 'SDHG') == 3


def test_5():
    assert dld('programma', 'pogarmmma') == 3


def test_6():
    assert dld('CA', 'ABC') == 3


def test_7():
    assert dld('abcd', 'abdc') == 1