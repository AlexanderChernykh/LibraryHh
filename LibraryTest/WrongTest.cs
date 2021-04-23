using LibraryHh;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTest
{
    class WrongTest
    {

        [Test]
        public void AreaCircle()
        {
            double area;
            area = Area.AreaCalculation(4);
            Assert.AreEqual(79.5, area);
        }

        [Test]
        public void AreaЕriangle()
        {
            double area;
            area = Area.AreaCalculation(3, 4, 5);
            Assert.AreEqual(7.5, area);
        }

        [Test]
        public void IsRightAngledTriangle()
        {
            bool isRightAngledTriangle = Area.IsRightAngledTriangle(3, 10, 5);
            Assert.AreEqual(true, isRightAngledTriangle);
        }
    }
}
