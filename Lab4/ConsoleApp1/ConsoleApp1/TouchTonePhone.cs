using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entity
{
    internal class TouchTonePhone : Rotaries
    {
        public TouchTonePhone(int number) 
            : base(number)
        {
            ValidSymbols = new string[12] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "*", "#" };
        }

        public new void ReceiveCall()
        {
            Console.WriteLine($"{PhoneNumber} this number is calling you!");
        }

    }
}
