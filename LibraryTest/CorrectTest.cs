using LibraryHh;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTest
{
    class CorrectTest
    {
        [Test]
        public void CorrectAreaTriangle()
        {
            Triangle triangle = new Triangle("Треугольник",3,4,5);
            Assert.AreEqual(6, triangle.Area());
        }

        [Test]
        public void CorrectIsRightAngledTriangle()
        {
            Triangle triangle = new Triangle("Треугольник", 3, 4, 5);
            Assert.AreEqual(true, triangle.IsRightAngledTriangle());
        }

        [Test]
        public void CorrectAreaCircle()
        {
            var circle = new Circle("Круг",2);
            Assert.AreEqual(12.566370614359172, circle.Area());
        }

    }
}
