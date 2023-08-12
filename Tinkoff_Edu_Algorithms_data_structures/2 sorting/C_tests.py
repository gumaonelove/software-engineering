from C import main


def test_1():
    lines = ['20', '287']
    answer = '28720'
    assert ''.join(main(lines)) == answer
    assert ''.join(main(lines[::-1])) == answer


def test_2():
    lines = ['29', '287']
    answer = '29287'
    assert ''.join(main(lines)) == answer
    assert ''.join(main(lines[::-1])) == answer


def test_3():
    lines = ['28', '280']
    answer = '28280'
    assert ''.join(main(lines)) == answer
    assert ''.join(main(lines[::-1])) == answer


def test_4():
    lines = ['20', '2', '004', '66']
    answer = '66220004'
    assert ''.join(main(lines)) == answer
    assert ''.join(main(lines[::-1])) == answer


def test_5():
    lines = ['3']
    answer = '3'
    assert ''.join(main(lines)) == answer
    assert ''.join(main(lines[::-1])) == answer


def test_6():
    lines = ['2', '200', '02']
    answer = '220002'
    assert ''.join(main(lines)) == answer
    assert ''.join(main(lines[::-1])) == answer


def test_7():
    lines = ['2', '0003', '002']
    answer = '20020003'
    assert ''.join(main(lines)) == answer
    assert ''.join(main(lines[::-1])) == answer


def test_8():
    lines = ['000324', '001342', '11000', '010101', '11111000', '011110']
    answer = '1111100011000011110010101001342000324'
    assert ''.join(main(lines)) == answer
    assert ''.join(main(lines[::-1])) == answer


def test_9():
    lines = ['99', '98', '990', '980', '099', '098', '0990', '0980', '09', '89']
    answer = '9999098980890990990098098009'
    assert ''.join(main(lines)) == answer
    assert ''.join(main(lines[::-1])) == answer


def test_10():
    lines = ['456456', '4564560', '4564569', '45645640', '45645649', '456456450', '456456459']
    answer = '456456945645649456456459456456456456450456456404564560'
    assert ''.join(main(lines)) == answer
    assert ''.join(main(lines[::-1])) == answer


def test_11():
    lines = ['00000100000', '10000', '0001']
    answer = '10000000100000100000'
    assert ''.join(main(lines)) == answer
    assert ''.join(main(lines[::-1])) == answer


def test_12():
    lines = ['100', '1000']
    answer = '1001000'
    assert ''.join(main(lines)) == answer
    assert ''.join(main(lines[::-1])) == answer


def test_13():
    lines = ['101', '10001', '2']
    answer = '210110001'
    assert ''.join(main(lines)) == answer
    assert ''.join(main(lines[::-1])) == answer


def test_14():
    lines = ['199' , '19991']
    answer = '19991199'
    assert ''.join(main(lines)) == answer
    assert ''.join(main(lines[::-1])) == answer


def test_15():
    lines = ['1' * 100] * 10000
    answer = '1' * 10000 * 100
    assert ''.join(main(lines)) == answer
    assert ''.join(main(lines[::-1])) == answer