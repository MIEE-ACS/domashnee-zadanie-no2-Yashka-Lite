using System;
using System.Globalization;

namespace Dz2._1
{
    class Program
    {

        static int r;

        static double Segment1(double x)
        {
            return 2;
        }

        static double Segment2(double x)
        {
            return 0.25*x+0.5;
        }

        static double Segment3(double x)
        {
            double a = -2;
            double b = 2;
            double y = -Math.Sqrt(r * r - (x-a) * (x-a))+b;

            return y;
        }
        static double Segment4(double x)
        {
            double a = 0;
            double b = 0;
            double y = Math.Sqrt(r * r - (x-a) * (x-a)) - b;

            return y;
        }
        static double Segment5(double x)
        {
            return -x+2;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите радиус r:");
            string R;
            do
            {
                R = Console.ReadLine();
                if (int.TryParse(R, out r))
                {
                    break;
                }
                Console.WriteLine("Введите число или радиус должен быть целым числом.");
            } while (true);
            if (r < 2)
            {
                Console.WriteLine("\nЗначение r меньше радиуса окружности графика, поэтому функция будет иметь область неопределенных значений\n");
            }
            Console.WriteLine("Таблица:");
            for (double x = -7; x <= 3.1; x += 0.2)
            {
                if (x < -7)
                {
                    Console.WriteLine("Функция не определена");
                }
                else if ((x >= -7) && (x < -5.9))
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment1(x));
                }
                if ((x > -6.1) && (x <= -1.9))
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment2(x));
                }
                if ((x >= -2.1)&&(x<0.1))
                {
                    
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment3(x));

                }
                if ((x > -0.1) && (x <= 2.1))
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment4(x));
                }
                if ((x > 1.9) && (x < 3.1))
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment5(x));
                }
            }
        }
    }
}
