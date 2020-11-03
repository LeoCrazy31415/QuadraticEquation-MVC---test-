using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int maxValueAbs = 10000;
        int accuracy = 4;
        Console.Write("Введите коэффициенты\na: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        Controller controller = new Controller();
        controller.Input(a, b, c, accuracy, maxValueAbs);
        Console.Write($"Корни уравнения: ");
        foreach (object obj in controller.Output)
        {
            Console.Write($"{obj} ");
        }
        Console.ReadKey();
    }
}