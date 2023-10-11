using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Circle : Shape
    {
        private double _radius;
        public double Radius
        {
            get => _radius;
            set => _radius = value;
        }
        public Circle(double radius) : base(radius)
        {
            if (radius > 0)
            {
                _radius = radius;
            }
            else
            {
                throw new Exception("There is no circle with such a radius");
            }
        }
        internal Circle(double[] parametrs)
        {
            if (parametrs[0] > 0)
            {
                _radius = parametrs[0];
            }
            else
            {
                throw new Exception("There is no circle with such a radius");
            }

            Name = "Circle";
        }
        public override double Square()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
