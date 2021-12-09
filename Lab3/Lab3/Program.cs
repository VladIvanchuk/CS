using System;

namespace Lab3
{
    class Program

    //8.	Перевірити істинність вислову: "Серед трьох даних цілих чисел є хоч би одна пара взаємно протилежних". 
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int thirdNum = Convert.ToInt32(Console.ReadLine());

            if (firstNum == secondNum * (-1) || secondNum == thirdNum * (-1) || firstNum == thirdNum * (-1))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }  
        }
    }
}
