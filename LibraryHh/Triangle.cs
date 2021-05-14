using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHh
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(string nameShape, double sideA, double sideB, double sideC) : base(nameShape)
        {
            if (IsExist(sideA,sideB,sideC))
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }         
        }

        public override double Area()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        private bool IsExist(double sideA, double sideB, double sideC)
        {
            if (sideA > sideB + sideC || sideB > sideA + sideC || sideC > sideA + sideB)
            {
                throw new ArgumentException("Такого треугольника не существует");
            }
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Стороны треугольника не могут быть меньше или равны 0");
            }
            return true;
        }

        public bool IsRightAngledTriangle()
        {
            bool isRightAngledTriangle = Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2)
                || Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2)
                || Math.Pow(SideC, 2) == Math.Pow(SideB, 2) + Math.Pow(SideA, 2);
            return isRightAngledTriangle;
        }

        public override string ToString()
        {
            string message = $"{base.NameShape} имеет стороны A={SideA} B={SideB} C={SideC}, площадь {Area()}";
            if (IsRightAngledTriangle())
            {
                return message + " и является прямоугольным";
            }
            return message;
        }


    }
}
