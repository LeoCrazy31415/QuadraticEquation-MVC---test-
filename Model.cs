using System;
using System.Collections.Generic;

class Model
{
    List<object> obj; //Список входных данных
    List<object> roots; //Список выходных данных
    int accuracy;
    //Конструктор модели
    public Model()
    {
        obj = new List<object>();
        roots = new List<object>();        
        accuracy = 4;
    }
    
    public void Input(object a, object b, object c)
    {
        obj.Add(a);
        obj.Add(b);
        obj.Add(c);
        Solution();
    }

    public List<object> Output
    {
        get { return roots; }
    }

    private List<object> Solution()
    {
        double a = (double)obj[0];
        double b = (double)obj[1];
        double c = (double)obj[2];
        //Если слишком большие значения
        if (Check(obj))
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0) //b^2 > 4*a*c
            {
                if (a == 0 && c == 0)
                {
                    double x = 0;
                    roots.Add(x);
                }
                else if (a == 0)
                {
                    double x = -c / b;
                    roots.Add(x);
                }
                else if (c == 0)
                {
                    double x1 = 0;
                    double x2 = -b / a;
                    roots.Add(x1);
                    roots.Add(x2);
                }
                else
                {
                    double x1 = Math.Round((-b + Math.Sqrt(D)) / 2 * a, accuracy);
                    double x2 = Math.Round((-b - Math.Sqrt(D)) / 2 * a, accuracy);
                    roots.Add(x1);
                    roots.Add(x2);
                }
            }
            else if (D == 0) //b^2 = 4*a*c
            {
                if (b == 0 && a == 0)
                {
                    return roots;
                }
                else if (b == 0 && c == 0)
                {
                    double x = 0;
                    roots.Add(x);
                }
                else
                {
                    double x = Math.Round(-b / 2 * a, accuracy);
                    roots.Add(x);
                }
            }
            else //b^2 < 4*a*c --> complex numbers
            {
                if (b == 0) //D = - 4*a*c
                {
                    double x1 = -Math.Round(Math.Sqrt(-D) / 2 * a, accuracy);
                    double x2 = Math.Round(Math.Sqrt(-D) / 2 * a, accuracy);
                    roots.Add(x1 + "i");
                    roots.Add(x2 + "i");
                }
                else
                {
                    double x1 = -Math.Round(-b + Math.Sqrt(-D) / 2 * a, accuracy);
                    double x2 = Math.Round(-b - Math.Sqrt(-D) / 2 * a, accuracy);
                    roots.Add(x1 + "i");
                    roots.Add(x2 + "i");
                }
            }
        }
        else
            roots.Add("Это не уравнение");
        return roots;
    }

    private bool Check(List<object> obj) //Проверка на соответствие требованиям уравнения
    {
        if ((double)obj[0] != 0 && (double)obj[1] != 0)
        {
            return true;
        }
        return false;
    }
}