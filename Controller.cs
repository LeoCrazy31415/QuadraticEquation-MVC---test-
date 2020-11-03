using System;
using System.Collections.Generic;

class Controller
{
    Model model;
    //Конструктор контроллера
    public Controller()
    {
        model = new Model();
    }

    public void Input(object a, object b, object c, object accuracy, object maxValueAbs)
    {
        model.obj.Add(a);
        model.obj.Add(b);
        model.obj.Add(c);
        model.Solution((int)accuracy, (int)maxValueAbs);
    }

    public List<object> Output
    {
        set { model.roots = value; }
        get { return model.roots; }
    }
}