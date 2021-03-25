using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiProject_2._1.Models
{
	public class DriverBus : Person
	{

		int price;
		int rate;
		public int Price { get { return price; } set { price = value; } }
		public int Rate { get { return rate; } set { rate = value; } }
		public DriverBus(string name = "", int rate = 0, int price = 0) : base(name)
		{

			Rate = rate;
			Price = price;

		}
		public static bool operator >(DriverBus first, DriverCar second)
		{
			return (first.Rate > second.Rate);
		}
		public static bool operator <(DriverBus first, DriverCar second)
		{
			return (first.Rate < second.Rate);
		}

		public string GetInfo()
		{

			return string.Format(name + " " + rate + " " + price);
		}

		public override string ToString()
		{
			return $"\n_-_-_-_-_-_Info of the bus driver_-_-_-_-_-_: \nName: {name}\nResidence: {Residence}\nRate: {rate}\nPrice: {price}";
		}
	}
}
