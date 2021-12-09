using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	class Garage
	{
		List<Car> cars;
		public Garage()
		{
			cars = new List<Car>();
		}
		public void AddCar(Car c)
		{
			this.cars.Add(c);
		}
		public void DeleteCar(Car c)
		{
			this.cars.Remove(c);
		}
		public Car MyCar(ConsoleColor color)
		{
			for (int i = 0; i < this.cars.Count; i++)
			{
				if (color == this.cars[i].Color)
				{
					return this.cars[i];
				}
			}
			Console.WriteLine("sorry there is no such car, here is your first car");
			return cars[0];
		}

		public Car MyCar(string brand)
		{
			for (int i = 0; i < this.cars.Count; i++)
			{
				if (brand == this.cars[i].Brands)
				{
					return this.cars[i];
				}
			}
			Console.WriteLine("sorry there is no such car, here is your first car");
			return cars[0];
		}

		public Car MyCar(short year)
		{
			if (year >= 1600)
			{
				for (int i = 0; i < this.cars.Count; i++)
				{
					if (year == this.cars[i].Year)
					{
						return this.cars[i];
					}
				}
			}
			else
			{
				for (int i = 0; i < this.cars.Count; i++)
				{
					if (year == this.cars[i].Horsepower)
					{
						return this.cars[i];
					}
				}
			}
			Console.WriteLine("sorry there is no such car, here is your first car");
			return cars[0];
		}
		public void BringCars()
		{
			ConsoleColor before = Console.BackgroundColor;
			for (int i = 0; i < this.cars.Count; i++)
			{
				Console.BackgroundColor = this.cars[i].Color;
				Console.Write(this.cars[i].ToString());
			}
			Console.BackgroundColor = before;
		}
	}
}
