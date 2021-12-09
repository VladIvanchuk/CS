using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entity
{
    internal class ColourPhone : BlackWhiteScreenPhone
    {
        protected int numberColor;
        protected bool isTwoSimCard;
        protected int secondNumber;

        protected int NumberColor { get => numberColor; set => numberColor = value; }
        protected bool IsTwoSimCard { get => isTwoSimCard; set => isTwoSimCard = value; }
        protected int SecondNumber { get => secondNumber; set => secondNumber = value; }

        public ColourPhone(int number, int numberColor, bool isTwoSimCard, int secondNumber,
           float resolution, double sizeScreen, string color)
           : base(number, resolution, sizeScreen, color)
        {
            NumberColor = numberColor;
            IsTwoSimCard = isTwoSimCard;
            SetSecondNumber(secondNumber);
            ValidSymbols = new string[15] { "1", "2", "3", "4", "5",
                "6", "7", "8", "9", "0", "*", "#", "!", "-", "+" };
        }

        public void SetSecondNumber(int secondNumber)
        {
            if (isTwoSimCard)
            {
                SecondNumber = secondNumber;
            }
            else
                Console.WriteLine("Error::You have only one SIM Card");
        }

        public void SendMMS(string message)
        {
            Console.WriteLine("You mail this MMS: " + message);
        }

        public void ReceiveMMS()
        {
            Console.WriteLine("New MMS!!");
        }

    }

}
