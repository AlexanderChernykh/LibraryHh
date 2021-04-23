using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHh
{
    public class Area
    {
        //Вычисление площади круга по радиусу
        public static double AreaCalculation(double radius)
        {
            double area = 3.14 * Math.Pow(radius,2);
            return area;
        }

        //Вычисление площади треугольника по 3-м сторонам
        public static double AreaCalculation(double a, double b, double c)
        {
            double semiPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a)*(semiPerimeter - b)*(semiPerimeter - c));
            return area;
        }

        public static bool IsRightAngledTriangle(double a, double b, double c)
        {
            bool isRightAngledTriangle = Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2) 
                || Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2) 
                || Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2);
            return isRightAngledTriangle;
        }
    }
}
