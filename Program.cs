using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_задача
{
    class Program
    {
        static void Main(string[] args)
        {

            double x, y;
            Console.WriteLine("Задача № 3");
            Console.Write("Введи x=");
            while (!Double.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("Ошибка, введите число!");
            Console.Write("Введи y=");
            while (!Double.TryParse(Console.ReadLine(), out y))  
            Console.WriteLine("Ошибка, введите число!");

            if ((y >= 0) && (Math.Pow(x, 2) + Math.Pow(y,2) >= 1) && (Math.Pow(x, 2) + Math.Pow(y, 2) <= 4))
                Console.WriteLine("u = 0");
            else Console.WriteLine("u={0}", x);
            Console.ReadKey();
        }
    }
}
