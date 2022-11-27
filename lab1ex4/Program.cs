using System;

namespace lab1ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //semnul numarului introdus(+,-,0)
            int a;
            Console.WriteLine("Introduceti un numar: ");
            a = int.Parse(Console.ReadLine());
            if (a > 0) Console.WriteLine("+");
            else if (a < 0) Console.WriteLine("-");
            else Console.WriteLine("0");
        }
    }
}
