using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace diff2por
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //запрашиваем первый коэффициент
                Console.WriteLine("Решение дифференциального уравнения вида:\r\ny''+ y' + y = 0");
                Console.WriteLine("Введите коэффициент перед y'':");
                var a = double.Parse(Console.ReadLine());

                //запрашиваем второй каэффициент
                Console.WriteLine("Введите коэффициент перед y' (если y' нет, то 0):");
                var b = double.Parse(Console.ReadLine());

                //запрашиваем третий коэффициент
                Console.WriteLine("Введите коэффициент перед y (если y нет, то 0):");
                var c = double.Parse(Console.ReadLine());

                //выводим общее характеристическое уравнение
                Console.WriteLine("Общее характеристическое уравнение:");
                Console.WriteLine(a+"*L^(2) + "+b+ "*L + " + c);

                //ищем дискриминант
                double x1, x2;
                var D = Math.Pow(b, 2) - 4 * a * c;
                if (D < 0)
                {
                    Console.WriteLine("Дискриминант меньше нуля, корней нет.");
                }
                else
                {
                    if (D == 0)
                    {
                        Console.WriteLine("Дискриминант равен нулю, один корень.");
                        x1 = -b / (2 * a);
                        x2 = x1;
                    }
                    else
                    {
                        Console.WriteLine("Дискриминант больше нуля, два корня.");
                        x1 = (-b + Math.Sqrt(D)) / (2 * a);
                        x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    }
                    Console.WriteLine($"Решение уравнения: y = C1*e^(" + x1 + "*x) + C2*e^("+ x2 + "*x)");
                    Console.ReadLine();
                }
            }
        }
    }
}
