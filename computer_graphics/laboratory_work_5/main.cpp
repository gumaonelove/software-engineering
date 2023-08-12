//
//  main.cpp
//  lab_5_num_1
//
//  Created by Булат Гумеров on 28.03.2023.
//

#include <iostream>
#define GL_SILENCE_DEPRECATION

#include <GLUT/GLUT.h>
#include <math.h>
#include <iostream>
#include <glaux.h>
#pragma comment(lib, "C:\\Users\\79196\\Desktop\\glaux.lib") #pragma comment(lib, "legacy_stdio_definitions.lib")
float BG[] = { 0.4, 0.4, 0.4, 0.0 };
float eyes[] = { 3, 5, 3 };
float figPos[] = { 0.0, 0.0, 0.0 };
float lightPos[] = { 3.0, 3.0, 4.0, 1.0 };
const GLfloat ambient[] = { 0.19125, 0.0735, 0.0225, 1 };
const GLfloat diffuse[] = { 0.7038, 0.27048, 0.0828, 1 };
const GLfloat specular[] = { 0.256777, 0.137622, 0.086014, 1 }; const GLfloat shininess[] = { 12.8 };
const int dADefault = 1; int lightAngle = 0;
int figureAngle = 0;
bool hideFront = false; bool hideBack = false; bool rotateLight = false; bool rotateFigure = true;
GLuint list = 0;
AUX_RGBImageRec* img1, * img2, * img3;
float s = 0.25;
void drawInit() {
img1 = auxDIBImageLoadA("C:\\Users\\79196\\Desktop\\a.bmp"); img2 = auxDIBImageLoadA("C:\\Users\\79196\\Desktop\\a.bmp"); img3 = auxDIBImageLoadA("C:\\Users\\79196\\Desktop\\a.bmp");
list = glGenLists(1); //Генерация незадействованного индекса списка glNewList(list, GL_COMPILE); //Создание списка и накопление команд glEnable(GL_DEPTH_TEST);
glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR);

glEnable(GL_TEXTURE_2D);
// верхняя glBegin(GL_POLYGON); glNormal3f(0, 0, 1); glVertex3f(0, 1, 1); glVertex3f(-1, -1, 1); glVertex3f(1, -1, 1); glEnd();
// лицевая
glTexImage2D(GL_TEXTURE_2D, 0, GL_RGB, img1->sizeX, img1->sizeY, 0, GL_RGB, GL_UNSIGNED_BYTE, img1->data);
glBegin(GL_POLYGON);
glNormal3f(0, -0.5, 1);
glTexCoord2f(0, 0); glVertex3f(-2, -2, -1); glTexCoord2f(1, 0); glVertex3f(2, -2, -1); glTexCoord2f(1 - s, 1); glVertex3f(1, -1, 1); glTexCoord2f(s, 1); glVertex3f(-1, -1, 1); glEnd();
// правая
glTexImage2D(GL_TEXTURE_2D, 0, GL_RGB, img2->sizeX, img2->sizeY, 0, GL_RGB, GL_UNSIGNED_BYTE, img2->data);
glBegin(GL_POLYGON);
glNormal3f(0.5, 0.5, 1);
glTexCoord2f(0, 0); glVertex3f(2, -2, -1); glTexCoord2f(1, 0); glVertex3f(0, 2, -1); glTexCoord2f(1 - s, 1); glVertex3f(0, 1, 1); glTexCoord2f(s, 1); glVertex3f(1, -1, 1); glEnd();
// левая
glTexImage2D(GL_TEXTURE_2D, 0, GL_RGB, img3->sizeX, img3->sizeY, 0, GL_RGB, GL_UNSIGNED_BYTE, img3->data);
glBegin(GL_POLYGON);
glNormal3f(-0.5, -0.5, 1);
glTexCoord2f(0, 0); glVertex3f(0, 2, -1); glTexCoord2f(1, 0); glVertex3f(-2, -2, -1); glTexCoord2f(1 - s, 1); glVertex3f(-1, -1, 1); glTexCoord2f(s, 1); glVertex3f(0, 1, 1); glEnd();
glDisable(GL_TEXTURE_2D);
// Нижняя glBegin(GL_POLYGON); glNormal3f(0, 0, -0.5);

glVertex3f(0, 2, -1); glVertex3f(2, -2, -1); glVertex3f(-2, -2, -1); glEnd();
glEndList(); //Завершение накопления команд в списке }
void init() {
glClearColor(BG[0], BG[1], BG[2], BG[3]); glMatrixMode(GL_PROJECTION); glLoadIdentity();
gluPerspective(60, 1, 1, 10); glMatrixMode(GL_MODELVIEW); glLoadIdentity();
}
void drawAxis(GLfloat lineLen) { glBegin(GL_LINES);
glColor3f(1, 0, 0); glVertex3f(0, 0, 0); glVertex3f(lineLen, 0, 0);
glColor3f(0, 1, 0); glVertex3f(0, 0, 0); glVertex3f(0, lineLen, 0);
glColor3f(0, 0, 1); glVertex3f(0, 0, 0); glVertex3f(0, 0, lineLen);
glEnd(); }
void drawLight() { glBegin(GL_LINES);
glColor3f(1, 1, 1);
glVertex3f(0, 0, 0);
glVertex3f(lightPos[0], lightPos[1], lightPos[2]); glEnd();
}
void myDisplay()

{
glPushMatrix();
// Отчистка, взгяд, оси
glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT); gluLookAt(eyes[0], eyes[1], eyes[2], figPos[0], figPos[1], figPos[2], 0, 0, 1); drawAxis(5);
// Освещение
glPushMatrix();
glRotatef(lightAngle, 0, 0, 1);
drawLight();
glEnable(GL_DEPTH_TEST);
glLightfv(GL_LIGHT0, GL_POSITION, lightPos); glLightf(GL_LIGHT0, GL_CONSTANT_ATTENUATION, 1.0); glEnable(GL_LIGHTING);
glEnable(GL_LIGHT0); glPopMatrix();
//Сокрытие граней if (hideFront) {
glCullFace(GL_BACK); }
if (hideBack) { glCullFace(GL_FRONT);
} glEnable(GL_CULL_FACE);
glMaterialfv(GL_FRONT, GL_SHININESS, shininess); glMaterialfv(GL_FRONT, GL_AMBIENT, ambient); glMaterialfv(GL_FRONT, GL_SPECULAR, specular); glMaterialfv(GL_FRONT, GL_DIFFUSE, diffuse);
// Отрисовка фигуры
glPushMatrix();
glRotatef(figureAngle, 0, 0, 1);
glCallList(list); //Вызов списка накопленных ранее команд glPopMatrix();
// Отключение освещения glPushMatrix(); glDisable(GL_LIGHTING); glPopMatrix();
glPopMatrix();
glutSwapBuffers(); }

void myReshape(int width, int height) {
if (width < height) {
glViewport(0, 0, width, width);
} else {
glViewport(0, 0, height, height); }
}
void myIdle() {
if (rotateFigure) {
figureAngle += dADefault;
}
if (figureAngle >= 360) {
figureAngle = 0; }
if (rotateLight) {
lightAngle -= dADefault;
}
if (lightAngle <= -360) {
lightAngle = 0; }
glutPostRedisplay(); }
void myKeyboard(unsigned char key, int x, int y) {
if (key == 'o' or key == 'щ') { rotateFigure = not rotateFigure;
}
else if (key == 'l' or key == 'д') {
rotateLight = not rotateLight; }
else if (key == 'f' or key == 'а') { hideFront = not hideFront;
}
else if (key == 'b' or key == 'и') {
hideBack = not hideBack; }
}
void myMouse(int button, int state, int x, int y) {

if (button == GLUT_LEFT_BUTTON)
glTexEnvi(GL_TEXTURE_ENV, GL_TEXTURE_ENV_MODE, GL_DECAL);
else if (button == GLUT_RIGHT_BUTTON) glTexEnvi(GL_TEXTURE_ENV, GL_TEXTURE_ENV_MODE,
GL_MODULATE); }
int main(int argc, char* argv[]) {
glutInit(&argc, argv);
glutInitDisplayMode(GLUT_RGBA | GLUT_DOUBLE | GLUT_DEPTH);
glutInitWindowSize(500, 500); glutInitWindowPosition(400, 400); glutCreateWindow("Lab 5.3");
drawInit(); glutDisplayFunc(myDisplay); glutReshapeFunc(myReshape); glutIdleFunc(myIdle); glutKeyboardFunc(myKeyboard); glutMouseFunc(myMouse);
init();
glutMainLoop(); }
