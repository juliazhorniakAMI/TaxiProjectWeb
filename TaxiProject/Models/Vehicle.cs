using System;
using System.Collections.Generic;
using System.Text;
using TaxiProject_2._1.Repository;
namespace TaxiProject_2._1.Models
{
	public class Vehicle : Entity
	{
		public string img;

		protected int number;
		protected string color;
		protected int maxSpeed;
		public string make;
		public string Img { get { return img; } set { img = value; } }
		public int Number { get { return number; } set { number = value; } }
		public string Color { get { return color; } set { color = value; } }
		public int MaxSpeed { get { return maxSpeed; } set { maxSpeed = value; } }
		public string Make { get { return make; } set { make = value; } }
		public int Rate { get; set; }
		public string Name { get; set; }
		public string GetInfo()
		{

			return string.Format(make + " " + number + " " + color + " " + MaxSpeed + " "+Img);
		}

		public Vehicle(string make = "", int number = 0, string color = "", int maxSpeed = 0,string img="")
		{
			Make = make;

			Number = number;
			Color = color;
			MaxSpeed = maxSpeed;
			Img = img;

		}
	}
}
