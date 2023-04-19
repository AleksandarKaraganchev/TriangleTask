using System;
namespace Triugulnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Въведи страна а на триъгълника: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Въведи височина h на триъгълника: ");
            double h = double.Parse(Console.ReadLine());
            Triugulnik triangle = new Triugulnik(a, h);
            Console.WriteLine($"Триъгълник e със страна --> {triangle.PrintA()}, и височина, която е към нея  --> {triangle.PrintH()}");
            triangle.Print();
            Console.WriteLine();
        }
    }
}
