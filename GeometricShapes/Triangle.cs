using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Triangle : Shape
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;
        public double FirstSide
        {
            get => _firstSide;
            set
            {
                if (ExistenceTriangle(value, _secondSide, _thirdSide))
                {
                    _firstSide = value;
                }
                else
                {
                    throw new Exception("It is impossible to change the length of the side, a triangle with such a side does not exist");
                }
            }
        }
        public double SecondSide
        {
            get => _secondSide;
            set
            {
                if (ExistenceTriangle(_firstSide, value, _thirdSide))
                {
                    _secondSide = value;
                }
                else
                {
                    throw new Exception("It is impossible to change the length of the side, a triangle with such a side does not exist");
                }
            }
        }
        public double ThirdSide
        {
            get => _thirdSide;
            set
            {
                if (ExistenceTriangle(_firstSide, _secondSide, value))
                {
                    _thirdSide = value;
                }
                else
                {
                    throw new Exception("It is impossible to change the length of the side, a triangle with such a side does not exist");
                }
            }
        }
        public bool IsRectangular
        {
            get
            {
                if (RectangualarTriangle())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        public Triangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
        {
            if (!ExistenceTriangle(firstSide, secondSide, thirdSide))
            {
                throw new Exception("There is no triangle with such sides");
            }
            else
            {
                _firstSide = firstSide;
                _secondSide = secondSide;
                _thirdSide = thirdSide;
            }
        }
        internal Triangle(double[] parametrs)
        {
            if (!ExistenceTriangle(parametrs[0], parametrs[1], parametrs[2]))
            {
                throw new Exception("There is no triangle with such sides");
            }
            else
            {
                _firstSide = parametrs[0];
                _secondSide = parametrs[1];
                _thirdSide = parametrs[2];
            }

            Name = "Triangle";
        }
        public override double Square()
        {
            double p = (_firstSide + _secondSide + _thirdSide) / 2;

            return Math.Sqrt(p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide));
        }
        private bool RectangualarTriangle()
        {
            if (_firstSide > _secondSide)
            {
                if (_firstSide > _thirdSide)
                {
                    if (_firstSide * _firstSide == _secondSide * _secondSide + _thirdSide * _thirdSide)
                    {
                        return true;
                    }
                }
                else
                {
                    if (_thirdSide * _thirdSide == _secondSide * _secondSide + _firstSide * _firstSide)
                    {
                        return true;
                    }
                }
            }
            else
            {
                if (_secondSide > _thirdSide)
                {
                    if (_secondSide * _secondSide == _firstSide * _firstSide + _thirdSide * _thirdSide)
                    {
                        return true;
                    }
                }
                else
                {
                    if (_thirdSide * _thirdSide == _secondSide * _secondSide + _firstSide * _firstSide)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private bool ExistenceTriangle(double firstSide, double secondSide, double thirdSide)
        {
            return (firstSide + secondSide > thirdSide) && (firstSide + thirdSide > secondSide) && (secondSide + thirdSide > firstSide);
        }
    }
}
