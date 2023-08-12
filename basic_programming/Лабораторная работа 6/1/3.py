'''
Реализуйте работающий светофор.
'''

from tkinter import *

alpha = 3


class Frame(Tk):

    def __init__(self):
        self.state = 0
        super().__init__()
        self.title('Светофор')
        self.canvas = c = Canvas(self, width=70*alpha, height=190*alpha, bg="gray")
        self.r = c.create_oval(10*alpha, 10*alpha, 60*alpha, 60*alpha, fill="#ff0000")
        self.y = c.create_oval(10*alpha, 70*alpha, 60*alpha, 120*alpha, fill="#808000")
        self.g = c.create_oval(10*alpha, 130*alpha, 60*alpha, 180*alpha, fill="#008000")
        c.pack()
        self.update()
        self.after(3000, self.upd)

    def upd(self):
        if self.state == 0:
            self.state = 1
            self.canvas.itemconfigure(self.r, fill='#800000')
            self.canvas.itemconfigure(self.y, fill='#ffff00')
            self.after(500, self.upd)
        elif self.state == 1:
            self.state = 2
            self.canvas.itemconfigure(self.y, fill='#808000')
            self.canvas.itemconfigure(self.g, fill='#00ff00')
            self.after(2000, self.upd)
        elif self.state == 2:
            self.state = 3
            self.canvas.itemconfigure(self.g, fill='#008000')
            self.canvas.itemconfigure(self.y, fill='#ffff00')
            self.after(750, self.upd)
        else:
            self.state = 0
            self.canvas.itemconfigure(self.r, fill='#ff0000')
            self.canvas.itemconfigure(self.y, fill='#808000')
            self.after(3000, self.upd)


root = Frame()
root.mainloop()