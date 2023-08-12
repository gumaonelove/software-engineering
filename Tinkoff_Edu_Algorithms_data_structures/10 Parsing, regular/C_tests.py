from C import change


def test_1():
    assert change('\circle{(60,280),2}') == '\circle{(280,60),2}'


def test_2():
    assert change('\circle{(60,90)}') == '\circle{(90,60)}'


def test_3():
    assert change('\gfill\circle{(90,960),2}') == '\gfill\circle{(960,90),2}'


def test_4():
    assert change('\circle{(90,60)}\gfill\circle{(960,90),2}') == '\circle{(60,90)}\gfill\circle{(90,960),2}'
