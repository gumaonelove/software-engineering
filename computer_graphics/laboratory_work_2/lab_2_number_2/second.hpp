//
//  second.hpp
//  lab_2_number_2
//
//  Created by Булат Гумеров on 07.03.2023.
//

#ifndef second_hpp
#define second_hpp

#define GL_SILENCE_DEPRECATION

#include <stdio.h>
#include <chrono>
#include <thread>

#include <GLUT/GLUT.h>
#include <stdlib.h>
#include <math.h>

#define PI 3.1459

GLfloat R = 640.0 / 480; //Форматное соотношение
GLfloat w = 40;  //Ширина мирового окна
GLfloat h; //Высота мирового окна
GLfloat l, r, b, t; //Параметры мирового окна
GLfloat f = 0;

void init(void)
{
    glMatrixMode(GL_PROJECTION);
    glLoadIdentity();
    gluOrtho2D(-15, 15, -15, 15);
    glClearColor(1.0, 1.0, 1.0, 0.0);
    glClear(GL_COLOR_BUFFER_BIT);
}

void figure1()
{
    glColor3f(0, 1, 1);
    glBegin(GL_QUADS);
    glVertex2f(2, 1);
    glVertex2f(-2, 1);
    glVertex2f(-2, -1);
    glVertex2f(2, -1);
    glEnd();

    glColor3f(0, 0, 0);
    glBegin(GL_LINES);
    glVertex2f(0, 0);
    glVertex2f(0, 3);
    glVertex2f(0, 0);
    glVertex2f(5, 0);
    glEnd();
}

void figure2(void)
{
    glColor3f(0.4, 0.4, 1.0);

    glBegin(GL_POLYGON);
    int x = 5;
    for (int a = 0; a <= 360; a += 1) {
        glVertex2f(x*cos(a) + 0, x*sin(a));
    }

    glEnd();
}

void axis(void)
{
    glColor3f(0.0, 0.0, 0.0);
    glBegin(GL_LINES);
    glVertex2f(0, 0);
    glVertex2f(3, 0);
    glVertex2f(0, 0);
    glVertex2f(0, 4.5);
    glEnd();
}

void display(void)
{
    glMatrixMode(GL_MODELVIEW);
    glLoadIdentity();
    glClearColor(1.0, 1.0, 1.0, 0.0);
    glClear(GL_COLOR_BUFFER_BIT);

    figure2();
    axis();
    if (f == 0) {
        glPushMatrix();
        glTranslatef(-7, 0, 0);
        glScalef(-1.0, -1.0, 1.0);
        glRotatef(0, 0, 0, 1);
        figure1();

        glPopMatrix();
    }

    if (f == 1) {
        glPushMatrix();
        glRotatef(90, 0, 0, 1);
        glTranslatef(-7, 0, 0);
        glScalef(-1, -1, -1.0);
        figure1();

        glPopMatrix();
    }

    if (f == 2) {
        glPushMatrix();
        glTranslatef(7, 0, 0);
        figure1();

        glPopMatrix();
    }

    if (f == 3) {
        glPushMatrix();
        glRotatef(90, 0, 0, 1);
        glTranslatef(7, 0, 0);
        figure1();

        glPopMatrix();
    }

    glFlush();
    glutSwapBuffers();
    f++;

    if (f == 4) {
        f = 0;
    }
    std::this_thread::sleep_for(std::chrono::milliseconds(100));
    
}
#endif /* second_hpp */
