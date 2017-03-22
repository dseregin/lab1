using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationSolver
{
    public class QuadraticEquation
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double X1 { get; private set; }
        public double X2 { get; private set; }

        public QuadraticEquation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool Solve()
        {
            double D = Math.Pow(B, 2) - 4 * A * C;

            if (D < 0)
            {
                Console.WriteLine("Действительных корней нет");
                
                return false;
            }
            else
            {
                X1 = (-B + Math.Sqrt(D)) / (2 * A);
                X2 = (-B - Math.Sqrt(D)) / (2 * A);
                
                return true;
            }
        }
    }
}
