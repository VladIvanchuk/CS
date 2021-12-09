using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entity
{
    internal class Rotaries
    {
        protected int phoneNumber;

        protected string[]? validSymbols = null;
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string[] ValidSymbols { get => validSymbols; set => validSymbols = value; }


        public Rotaries(int number)
        {
            PhoneNumber = number;
            ValidSymbols = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        }

        public void Call()
        {
            Console.WriteLine("You made a phone call!");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("You take the call!");
        }


    }
}
