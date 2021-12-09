using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entity
{
    internal class SmartPhone : ColourPhone
    {
        public SmartPhone(int number, int numberColor, bool isTwoSimCard, int secondNumber,
            float resolution, double sizeScreen, string color)
            : base (number,numberColor,isTwoSimCard,secondNumber,resolution,sizeScreen,color)
        {
            ValidSymbols = new string[15] { "1", "2", "3", "4", "5",
                "6", "7", "8", "9", "0", "*", "#", "!", "-", "+" };
        }

        public void CreatePhoto()
        {
            Console.WriteLine("You have created photo!");
        }

        public void CreateVideo()
        {
            Console.WriteLine("You have created video!");
        }
    }
}
