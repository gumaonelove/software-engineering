//
//  first.hpp
//  lab_2__number_1
//
//  Created by Булат Гумеров on 21.02.2023.
//

#ifndef first_hpp
#define first_hpp

#define GL_SILENCE_DEPRECATION

#include <GLUT/GLUT.h>
#include <stdlib.h>
#include <math.h>

#define PI 3.1459

GLfloat R = 640.0 / 480; //Форматное соотношение
GLfloat w = 40; //Ширина мирового окна
GLfloat h; //Высота мирового окна
GLfloat l, r, b, t; //Параметры мирового окна
GLfloat f = 45.0;
GLfloat size = 1.0, add = 0.05;

void init(void)
{
    h = w / R; l = -w / 2; r = w / 2; b = -h / 2; t = h / 2; //Расчет параметров мирового окна
    glClearColor(1.0, 1.0, 0.0, 0.0);
    glClear(GL_COLOR_BUFFER_BIT);
    glMatrixMode(GL_PROJECTION);
    glLoadIdentity();
    gluOrtho2D(l, r, b, t);
    glMatrixMode(GL_MODELVIEW);
    glLoadIdentity();
}

void reshape(GLsizei W, GLsizei H)
{
    if (R>W / H) glViewport(0, 0, W, W / R);
    else glViewport(0, 0, H*R, H);
}

void showAxis(void)
{
    glColor3f(0.0f, 0.0f, 1.0f);
    glBegin(GL_LINES);
    glVertex2f(-3.5, -14.2);
    glVertex2f(-3.5, t);
    glVertex2f(0, 0);
    glVertex2f(r, 0);
    glEnd();
}

void fig0(void)
{
    glColor3f(0.0, 1.0, 0.0);
    float x, y;
    glBegin(GL_LINE_STRIP);
    for (t = 0.01; t <= 360; t += 0.01) {
        x = sin(0.5*t) * 4;
        y = cos(0.5*t) * 4;
        glVertex2f(x, y);
    }
    glEnd();
}

void scene(void)
{
    glClear(GL_COLOR_BUFFER_BIT);
    //showAxis();
    //fig0();
    glPushMatrix();
    glTranslatef(7.0, 0.0, 0.0);
    glScalef(size, size, 0.0);
    fig0();
    glPopMatrix();
    glPushMatrix();
    glTranslatef(-7.0, 0.0, 0.0);
    //glScalef(size, -size, 0.0);
    glScalef(1 - size, 1 - size, 0.0);
    fig0();
    glPopMatrix();
    glFlush();
    glutSwapBuffers();
    size = size + add;
    if (size > 1.0 || size < 0.0) {
        add = -add;
    }
}

#endif /* first_hpp */
