using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Triangle
    {
        private double _a;
        public double A
        {
            get
            {
                return _a;
            }
            set
            {
                if (value > 0)
                {
                    _a = value;
                }
                else
                {
                    throw new Exception("Значение не может быть нулевым или отрицательным!");
                }
            }

        }
        private double _b;
        public double B
        {
            get
            {
                return _b;
            }
            set
            {
                if (value > 0)
                {
                    _b = value;
                }
                else
                {
                    throw new Exception("Значение не может быть нулевым или отрицательным!");
                }
            }

        }
        private double _c;
        public double C
        {
            get
            {
                return _c;
            }
            set
            {
                if (value > 0)
                {
                    _c = value;
                }
                else
                {
                    throw new Exception("Значение не может быть нулевым или отрицательным!");
                }
            }

        }
        public double Square()
        {
            double p = Perimetr() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public double Perimetr()
        {
            return A + B + C;
        }
        public Triangle(double a, double b, double c)
        {
            if ((a < b + c) && (a > b - c) && (b < a + c) && (b > a - c) && (c < a + b) && (c > a - b))
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                Console.WriteLine("Cторона треугольника меньше суммы двух других сторон и больше их разности!");
            }

        }
    }
}

