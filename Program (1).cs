using System;

namespace ConsoleApp52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            double y = x > 6.7 ? 4 - Math.Exp(4 * x) : Math.Log(3.5 + x);
            Console.WriteLine($"Результат = {y}");
            Console.ReadLine();
        }
    }
}