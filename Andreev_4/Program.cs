using System;

namespace Andreev_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //В зависимости от языка системы дробные числа с точкой не конвертируются из строк
            //поэтому точки вручную заменяем на запятые
            //.Replace(".", ",")

            Console.WriteLine("Введите x: ");
            double x = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Введите y: ");
            double y = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Введите n: ");
            double n = double.Parse(Console.ReadLine().Replace(".", ","));

            int sign = 1;
            double x_pow = x;

            double yfib1 = y;
            double yfib2 = y;

            double fact_i = 3;
            double fact = 2;

            double tgy_i = Math.Tan(y);
            double tgy = tgy_i;

            double A = 0.0;
            for (int i = 0; i < n; i++)
            {
                A += sign * yfib1 * yfib2 * Math.Sin(fact) / (tgy + Math.Pow(x_pow, i + 1));
                Console.WriteLine($"A(n={i}) = {A:F8}");

                sign *= -1;
                fact *= fact_i;
                
                double yfib = yfib1 * yfib2;

                yfib1 = yfib2;
                yfib2 = yfib;

                tgy *= tgy_i;
                x_pow *= x;
            }
        }
    }
}