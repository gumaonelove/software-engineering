//
//  second.cpp
//  lab_2_number_2
//
//  Created by Булат Гумеров on 07.03.2023.
//

#include "second.hpp"


int main(int argc, char **argv)
{
    glutInit(&argc, argv);
    glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB);
    glutInitWindowSize(640, 480);
    glutInitWindowPosition(0, 0);
    glutCreateWindow("Myprog");
    glutDisplayFunc(display);
    glutIdleFunc(display);
    init();
    glutMainLoop();
    return 0;
}
