using System;
using System.Collections.Generic;

class Controller
{
    Model model;
    //Конструктор контроллера
    public Controller(double a, double b, double c, int accuracy, int maxValueAbs)
    {
        model = new Model(a, b, c, accuracy, maxValueAbs);
    }

    public List<object> Input
    {
        get { return model.obj; }
    }

    public List<object> Output
    {
        set { model.roots = value; }
        get { return model.roots; }
    }
}