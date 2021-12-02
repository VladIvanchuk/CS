using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            int CountSide;
            double side;
            double r;
            Console.WriteLine("input radius : ");
            r = Convert.ToInt32(Console.ReadLine());
            while (r <= 0)
            {
                Console.WriteLine("input radius more zero : ");
                r = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("input Count side : ");
            CountSide = Convert.ToInt32(Console.ReadLine());
            while (CountSide <= 0)
            {
                Console.WriteLine("input Count side more zero : ");
                CountSide = Convert.ToInt32(Console.ReadLine());
            }
            side = 2 * r * Math.Tan(Math.PI / CountSide);
            Console.WriteLine(side);

            Console.WriteLine(side * CountSide);
        }
    }
}
