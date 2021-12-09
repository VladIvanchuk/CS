using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
	enum Color
	{
		Red,
		DarkCyan,
		Green,
		Yellow,
		DarkGreen
	}
	class Car
	{

		string Brand;
		private short speed;
		private short GraduationYear;
		private ConsoleColor color;

		public string Brands
		{
			set { this.Brand = value.ToUpper(); }
			get { return Brand; }
		}
		public short Horsepower
		{
			get { return speed; }
			set { speed = value; }
		}
		public short Year
		{
			get { return GraduationYear; }
			set { GraduationYear = value; }
		}
		public ConsoleColor Color
		{
			get { return color; }
			set { color = value; }
		}

		public Car(string brand, ConsoleColor color, short Horsepower, short year)
		{
			this.Brand = brand;
			this.Color = color;
			this.Horsepower = Horsepower;
			this.Year = year;
		}

		public override string ToString()
		{

			return $"Brand of this car: {this.Brand}, \nYear of this car: {this.Year}, \nHorsepower of this car: {this.speed} к.с., \nColor of this car: {this.color}\n";
		}

	}
}
