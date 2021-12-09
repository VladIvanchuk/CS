using System;
        
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)

        //5.	Перевірити істинність вислову: "Сума цифр даного тризначного числа є парним числом". 


        {
            int sum = 0;
            int num;
            Console.WriteLine("Enter the three-digit number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 99 && num < 1000)
            {
                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                if (sum % 2 == 0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
            else
            {
                Console.WriteLine("The number entered is not three digits!");
            }

        }
    }
}
