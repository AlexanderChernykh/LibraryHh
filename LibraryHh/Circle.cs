using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHh
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        
        public Circle(string nameShape,double radius) : base(nameShape)
        {
            if (IsExist(radius))
            {
                Radius = radius;
            }
        }

        private bool IsExist(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус не может быть меньше или равен 0");
            }
            return true;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"{NameShape} имеет радиус {Radius} и площадь {Area()}";
        }
    }
}
