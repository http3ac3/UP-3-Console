using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UP_3._1_Console
{
    internal class Program
    {
        static double Function(double x) => x * x * x - Math.Sin(x);
        static void Main(string[] args)
        {
            double a, b;

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

            double f_a = Function(a);
            double f_b = Function(b);

            Console.WriteLine($"В точке a ({a}) функция принимает значение {f_a}");
            Console.WriteLine($"В точке b ({b}) функция принимает значение {f_b}");

            string answ = (f_a > f_b) ? "Наибольшее значение функция принимает в точке а" : (f_a < f_b) ?
                "Наибольшее значение функция принимает в точке b" : "Значения функции в двух точках равны";
            Console.WriteLine(answ);
        }
    }
}
