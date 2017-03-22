using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Решение_квадратного_уравнения
{
    class Program
    {
        public static double[] FuncSolve(double a, double b, double c)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;

            if (D < 0)
            {
                return null;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                return new double[] { x1, x2 };
            }
        }

        public static void Func()
        {
            double a, b, c, d, x, x1;
            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();
            d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Действительных решений нет");

            }
            else
            {
                if (d == 0)
                {
                    x = -b / 2 * a;
                    Console.WriteLine("Уравнение имеет 1 корень:{0}", x);

                }
                else
                {
                    x = -b - Math.Sqrt(d) / 2 * a;
                    x1 = -b + Math.Sqrt(d) / 2 * a;
                    Console.WriteLine("Уравнение имеет 2 корня: {0} и {1}", x, x1);
                }
            } 
        }
        static void Main(string[] args)
        {
            /*var solve = new QuadraticEquation(1, 1, -12);
            var solve2 = new QuadraticEquation(1, 1, 12);

            Console.WriteLine("Первый случай:");
            if (solve.Solve())
            {
                Console.WriteLine("x1 = {0}, x2 = {1}", solve.X1, solve.X2);
            }

            Console.WriteLine("Второй случай:");
            if (solve2.Solve())
            {
                Console.WriteLine("Второй случай:\nx1 = {0}, x2 = {1}", solve.X1, solve.X2);
            }

            Console.WriteLine("Функция:");
            double[] funcSolve;
            if ((funcSolve = FuncSolve(4, 12, 9)) != null)
            {
                Console.WriteLine("х1 = {0}, x2 = {1}", funcSolve[0], funcSolve[1]);
            }
            else
            {
                Console.WriteLine("Действительных корней нет");
            }
            Console.ReadKey();*/

            Func();
            Console.ReadKey();
        }
    }
}
