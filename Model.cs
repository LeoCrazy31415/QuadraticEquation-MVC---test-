using System;
using System.Collections.Generic;

class Model
{
    internal List<object> obj; //Список входных данных
    internal List<object> roots; //Список выходных данных
    //Конструктор модели
    public Model()
    {
        roots = new List<object>();
        obj = new List<object>();
    }
    
    public List<object> Solution(int accuracy, int maxValueAbs)
    {
        double a = (double)obj[0];
        double b = (double)obj[1];
        double c = (double)obj[2];
        //Если слишком большие значения
        if (Math.Abs(a) > maxValueAbs || Math.Abs(b) > maxValueAbs || Math.Abs(c) > maxValueAbs)
        {
            roots.Clear();
            roots.Add("Слишком большие числа!");
            return roots;
        }
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