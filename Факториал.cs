using System;

namespace Факториал
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            long n = Convert.ToInt64(Console.ReadLine());
            long p = 1;
            for (int i = 2; i <= n; ++i)
                p *= i;
            Console.WriteLine("Результат: " + p);
            Console.ReadLine();
        }
    }
}