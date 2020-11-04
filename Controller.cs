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

    public void Input(object a, object b, object c)
    {
        model.Input(a, b, c);
    }

    public List<object> Output
    {
        get { return model.Output; }
    }
}