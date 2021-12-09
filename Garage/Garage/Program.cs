using System;

namespace Garage
{
	class Program
	{
		class DopTaskGarage
		{
			static void Main()
			{
				Garage garage = new Garage();
				Car FirstCar = new Car("Bugatti Chiron", ConsoleColor.DarkCyan, 1500, 2016);
				Car SecondCar = new Car("Lamborghini Huracan", ConsoleColor.Yellow, 610, 2017);
				Car ThirdCar = new Car("Ferrari Portofino", ConsoleColor.Green, 600, 2018);
				Car ForthCar = new Car("Porsche Taycan", ConsoleColor.Red, 761, 2019);
				Car FifthCar = new Car("Audi RS7", ConsoleColor.DarkGreen, 610, 2020);


				garage.AddCar(FirstCar);
				garage.AddCar(SecondCar);
				garage.AddCar(ThirdCar);
				garage.AddCar(ForthCar);
				garage.AddCar(FifthCar);

				Car MyCar = garage.MyCar("Audi RS7");
				ConsoleColor before = Console.BackgroundColor;
				Console.BackgroundColor = MyCar.Color;
				Console.WriteLine(MyCar);
				Console.BackgroundColor = before;

			}
		}
	}
}