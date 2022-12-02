using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_3._2_Console
{
    internal class Program
    {
        static double Function(double x, double a) => (x < a) ? 0 : (x > a) ? (x - a) / (x + a) : 1; 

        static void Main(string[] args)
        {
            double a, b, h;
            Console.Write("Введите а: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Были введены неверные данные! Попробуйте снова!");
                Console.Write("Введите а: ");
            }

            Console.Write("Введите b: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Были введены неверные данные! Попробуйте снова!");
                Console.Write("Введите b: ");
            }

            Console.Write("Введите h: ");
            while (!double.TryParse(Console.ReadLine(), out h))
            {
                Console.WriteLine("Были введены неверные данные! Попробуйте снова!");
                Console.Write("Введите h: ");
            }

            if ((a > b && h > 0) || (a < b && h < 0))
            {
                Console.WriteLine("Границы не определены! На указанном диапазоне шаг неверен");
                return;
            }

            Console.WriteLine("Таблица значений");
            Console.WriteLine("x\t|\ty"); Console.WriteLine("__________________");
            var count = (int)(Math.Ceiling(b - a) / h + 1);
            for (var i = 0; i < count; i++)
            {
                var x = a + i * h;
                Console.WriteLine($"{x}\t|\t{Function(x, a)}");
            }
        }
    }
}
