//
//  first.cpp
//  lab_2__number_1
//
//  Created by Булат Гумеров on 21.02.2023.
//

#include "first.hpp"


int main(int argc, char **argv)
{
    glutInit(&argc, argv);
    glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB);
    //glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB);
    glutInitWindowSize(640, 480);
    glutInitWindowPosition(20, 20);
    glutCreateWindow("Myprog");
    glutReshapeFunc(reshape);
    glRotatef(45, 0.0, 0.0, 1.0);
    glutDisplayFunc(scene);
    glutIdleFunc(scene);
    init();
    glutMainLoop();
    return 0;
}
