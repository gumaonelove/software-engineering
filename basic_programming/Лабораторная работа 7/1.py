import threading
import time

from random import choice
from string import ascii_uppercase

global_list = []


class ClockThread1(threading.Thread):
    '''1 поток'''

    def __init__(self, len):
        threading.Thread.__init__(self)
        self.deamon = True
        self.len = len

    def run(self):
        while True:
            global_list.append(self.get_random_string())

    def get_random_string(self):
        _string = ''
        for _ in range (self.len):
            _string += choice(ascii_uppercase)
        return _string


class ClockThread2(threading.Thread):
    '''2 поток'''

    def __init__(self):
        threading.Thread.__init__(self)
        self.deamon = True

    def run(self):
        while True:
            print(global_list)


class ClockThread3(threading.Thread):
    '''3 поток'''

    def __init__(self):
        threading.Thread.__init__(self)
        self.deamon = True

    def run(self):
        while True:
            global_list.sort()
            time.sleep(5)


t1 = ClockThread1(10)
t2 = ClockThread2()
t3 = ClockThread3()

t1.start()
t2.start()
t3.start()