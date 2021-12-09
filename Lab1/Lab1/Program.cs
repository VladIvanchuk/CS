using System;

namespace Lab1
{
    class Program
    {

//      Написати програму, що виконує наступні функції 
//1.	Виводить на екран введене число з клавіатури в зворотному порядку(1234->4321)
//2.	Виводить будь-яку строку в зворотному порядку(АБВ->ВБА)
//3.	Дробові числа виводяться в зворотному порядку і ціла частина і дробова(123.456->321.654)
//4.	Реалізувати метод, що буде масив повертати задом навпаки(Використання Array.Reverse() заборонено!)
//5.	Виконати пункт 4 з використанням ключових слів ref i out


        static void Main(string[] args)
        {
           Console.WriteLine("Enter the data type(integer, string, double, array): ");
           string type = Console.ReadLine();
           
 ////////////////////////////////////////////////////
            if (type == "integer" || type == "string")
            {
                string a = Console.ReadLine();


                for (int i = a.Length - 1; i >= 0; i--)
                {
                    Console.Write(a[i]);

                }

            }
 ////////////////////////////////////////////////////
            if (type == "double")
            {
                string nums = Console.ReadLine();

                string[] splitnums = nums.Split('.', ',');

                string f_part = splitnums[0];
                string s_part = splitnums[1];

                for (int i = f_part.Length - 1; i >= 0; i--)
                {
                    Console.Write(f_part[i]);

                }
                Console.Write(".");
                for (int i = s_part.Length - 1; i >= 0; i--)
                {
                    Console.Write(s_part[i]);

                }
                Console.ReadLine();
            }
 ////////////////////////////////////////////////////
            if (type == "array") {
                int[] array = new int[3];

                for (int i = 0; i < array.Length; i++)
                {

                    Console.WriteLine("Введите " + (i + 1) + " число");


                    array[i] = int.Parse(Console.ReadLine());

                }
                Result(ref array, out string res);

                Console.Write(res);
                Console.ReadLine();
            }


            static void Result(ref int[] arr, out string res)
            {
                string result = string.Empty;

                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    result += arr[i];
                }

                res = result;
            }

        }
    }
}
