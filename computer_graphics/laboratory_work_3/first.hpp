//
//  first.hpp
//  lab_3_number_1
//
//  Created by Булат Гумеров on 07.03.2023.
//

#ifndef first_hpp
#define first_hpp

#define GL_SILENCE_DEPRECATION

#include <stdio.h>
#include <GLUT/GLUT.h>
#include <math.h>
#include <iostream>

#define KEY_x 120
#define KEY_X 88

int my_key;
void drawIco();
void drawDod();

GLfloat angle = 0, dA = 0.5;
GLfloat myLightPosition[] = { 3.0, 3.0, 3.0, 1.0 };
GLfloat BG[] = { 0.0, 0.0, 0.0, 0.0 };
GLfloat lineLen = 50;
GLfloat eyes[3] = { 6.0, 4.0, 2.0 };
GLfloat figPos[3] = { 0.0, 0.0, 0.0 };


void (*figFunc)() = drawIco;

using namespace std;

void init(void)
{
    glClearColor(BG[0], BG[1], BG[2], BG[3]);
    glMatrixMode(GL_PROJECTION);
    glLoadIdentity();
    gluPerspective(60, 1, 1, 10);
    glMatrixMode(GL_MODELVIEW);
    glLoadIdentity();
}

void axis()
{
    glBegin(GL_LINES);
    glColor3f(1, 0, 0);
    glVertex3f(0, 0, 0);
    glVertex3f(lineLen, 0, 0);
    glColor3f(0, 1, 0);
    glVertex3f(0, 0, 0);
    glVertex3f(0, lineLen, 0);
    glColor3f(0, 0, 1);
    glVertex3f(0, 0, 0);
    glVertex3f(0, 0, lineLen);
    glEnd();
}

void lightning()
{
    glBegin(GL_LINES);
    glColor3f(1, 1, 1);
    glVertex3f(3, 3, 3);
    glVertex3f(0.0, 0.0, 0.0);
    glEnd();
}

void drawIco()
{
    glutSolidIcosahedron();
}

void drawDod()
{
    glutSolidDodecahedron();
}

void myDisplay()
{
    glPushMatrix();
    glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
    glEnable(GL_DEPTH_TEST);
    gluLookAt(eyes[0], eyes[1], eyes[2], figPos[0], figPos[1], figPos[2], 0, 1, 0);
    glLightfv(GL_LIGHT0, GL_POSITION, myLightPosition);
    axis();
    lightning();
    glEnable(GL_LIGHTING);
    glEnable(GL_LIGHT0);
    //
    glRotatef(angle, 1, 0, 0);
    glRotatef(angle, 0, 1, 0);
    glRotatef(angle, 0, 0, 1);
    //
    if (my_key == 1) {
        glRotatef(angle, 1, 0, 0);
    }
    glPushMatrix();
    figFunc();
    glDisable(GL_LIGHTING);
    glPopMatrix();
    glPopMatrix();
    glutSwapBuffers();
}

void myReshape(int width, int height)
{
    if (width < height)
    {
        glViewport(0, 0, width, width);
    } else {
        glViewport(0, 0, height, height);
    }
}

void myIdle()
{
    angle += dA;
    if (angle >= 360) {
        angle = 0;
    }
    glutPostRedisplay();
}
    
void myMouse(int button, int state, int x, int y) {
    if (state != GLUT_DOWN) {
        return;
    }
    if (button == GLUT_LEFT_BUTTON)
    {
        figFunc = drawIco;
    } else if (button == GLUT_RIGHT_BUTTON) {
        figFunc = drawDod;
    }
}

void myKeyboard(unsigned char key, int x, int y)
{
    if (key == KEY_x)
    {
        dA = 0.5;
        my_key = 1;
    } else if (key == KEY_X)
    {
        dA = 0;
    }
}

#endif /* first_hpp */
