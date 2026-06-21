using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Pro05
{
    internal class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * this.radius * this.radius;
        }
    }

    internal class MyClass
    {
        double r = 5.0;
        Circle c = new Circle(r)
        
    }

}
