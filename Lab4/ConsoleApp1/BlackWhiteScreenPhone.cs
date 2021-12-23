using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entity
{
    internal class BlackWhiteScreenPhone : TouchTonePhone 
    {
        protected float resolution;
        protected double sizeScreen;
        protected string color;

        protected float Resolution { get => resolution; set => resolution = value; }
        protected double SizeScreen { get => sizeScreen; set => sizeScreen = value; }
        protected string Color { get => color; set => color = value; }

        public BlackWhiteScreenPhone(int number,float resolution, double sizeScreen, string color)
            : base(number)
        {
            Resolution = resolution;
            SizeScreen = sizeScreen;
            Color = color;
        }

        public void SendSMS(string message)
        {
            Console.WriteLine("You sent this SMS: " + message);
        }

        public void ReceiveSMS()
        {
            Console.WriteLine("Receive SMS");
        }


    }
}
