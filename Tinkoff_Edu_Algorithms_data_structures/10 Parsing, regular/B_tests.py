from B import change


'''def test_0():
    changes = {
        'ci': 's',
        'ce': 's',
        'ck': '',
        'c': 'k',
        'ee': 'i',
        'oo': 'u',
        # в остальных комбинациях будут просто писать одну букву вместо двух одинаковых.
        'e': '',
    }
    for s in changes:
        assert change(s) == changes[s]


def test_1():
    assert change('success') == 'suksess'


def test_2():
    assert change('cck') == 'kk'


def test_3():
    assert change('ooo') == 'uo'


def test_4():
    assert change('oou') == 'u'


def test_5():
    assert change('iee') == 'i'


def test_6():
    assert change('the table') == 'tabl'


def test_7():
    assert change('aaaaa') == 'a' '''


def test_8():
    assert change('cacao and coffee') == 'kakao and kofi'


def test_9():
    assert change('Cinderella! Where Is The Dress???') == 'Sinderela! Wher Is Dres???'


def test_10():
    assert change("'A' is a letter") == "'' is leter"


def test_11():
    assert change('!!!Hello!!!A-the-"word"') == '!!!Helo!!!--"word"'