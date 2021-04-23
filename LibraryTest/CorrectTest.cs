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
        public void AreaCircle()
        {
            double area;
            area = Area.AreaCalculation(8);
            Assert.AreEqual(200,9, area);
        }

        [Test]
        public void AreaЕriangle()
        {
            double area;
            area = Area.AreaCalculation(3, 4, 5);
            Assert.AreEqual(6, area);
        }

        [Test]
        public void IsRightAngledTriangle()
        {
            bool isRightAngledTriangle = Area.IsRightAngledTriangle(3, 4, 5);
            Assert.AreEqual(true, isRightAngledTriangle);
        }
        [Test]
        public void IsRightAngledTriangleV2()
        {
            bool isRightAngledTriangle = Area.IsRightAngledTriangle(3, 10, 5);
            Assert.AreEqual(false, isRightAngledTriangle);
        }


    }
}
