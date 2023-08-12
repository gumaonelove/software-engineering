from D import main


def test_1():
    assert main(3, 'AAB') == 'ABA'


def test_2():
    assert main(6, 'QAZQAZ') == 'AQZZQA'


def test_3():
    assert main(6, 'ABCDEF') == 'A'


def test_4():
    assert main(3, 'ABC') == 'A'


def test_5():
    assert main(6, 'ABCDEF') == 'A'


def test_6():
    assert main(12, 'AAABBBCCCCDD') == 'ABCCDADCCBA'


def test_7():
    assert main(6, 'AAABBB') == 'ABABA'


def test_8():
    assert main(7, 'AAAAABB') == 'AABABAA'