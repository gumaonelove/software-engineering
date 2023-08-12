'''Реализуйте движение (анимацию) геометрической фигуры по
холсту.'''

from math import cos
from tkinter import Tk, Canvas, BOTH

HEIGHT = 100
WIDTH = 100
STEP = 0.2
INTERVAL = 100

angle = 0
root = Tk()
root.geometry(str(HEIGHT) + "x" + str(WIDTH))
canvas = Canvas(root)
points = [0, HEIGHT, WIDTH/2, 0, WIDTH, HEIGHT]
t = canvas.create_polygon(points, outline='red', fill='blue', width=2)
canvas.pack(fill=BOTH, expand=1)


def rotate(current_angle):
    angle = current_angle + STEP
    for i in range(len(points)//2):
        points[i] = i * WIDTH + i * WIDTH * cos(angle)

    canvas.coords(t, points)
    root.after(INTERVAL, lambda: rotate(angle))


root.after(INTERVAL, lambda: rotate(angle))

root.mainloop()