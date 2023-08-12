//
//  second.hpp
//  computer_graph
//
//  Created by Булат Гумеров on 21.02.2023.
//

#ifndef second_hpp
#define second_hpp
#define GL_SILENCE_DEPRECATION

#include <stdio.h>
#include <GLUT/GLUT.h>


void init() //Функция инициализации
{
    glClearColor(1.0, 1.0, 1.0, 0.0);
    glMatrixMode(GL_PROJECTION);
    glLoadIdentity();
    gluOrtho2D(0.0, 2.0, 0.0, 1.0);
}

void draw() //Функция рисования
{
    GLfloat l = -100, r = 100, b = -100, t = 100;
    GLint x = 0, y = 0, w = 60, h = 60;
    glClear(GL_COLOR_BUFFER_BIT);
    gluOrtho2D(l, r, b, t);
    for (x = 0; x <= 600; x += w)
        for (y = 0; y <= 480; y += h)
        {
            glViewport(x, y, w, h);
            glColor3f(1.0, 0.0, 0.0);
            glBegin(GL_TRIANGLES);
            glVertex2f(100.0, 100.5);
            glVertex2f(20.1, 30.5);
            glVertex2f(15.1, 10.6);
            glEnd();
        }
    glFlush();
}

#endif /* second_hpp */
