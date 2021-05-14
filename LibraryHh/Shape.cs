using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHh
{
    public abstract class Shape
    {
        public string NameShape { get; set; }

        public Shape(string nameShape)
        {
            NameShape = nameShape;
        }
        public abstract double Area();
    }
}
