using System;
using System.Collections.Generic;
using System.Text;
using TaxiProject_2._1.Repository;

namespace TaxiProject_2._1.Models
{
	public class DriverCar : Person
	{

		int price;
		int rate;
		public int Price { get { return price; } set { price = value; } }
		public int Rate { get { return rate; } set { rate = value; } }
		public DriverCar(string name = "", int rate = 0, int price = 0) : base(name)
		{

			Rate = rate;
			Price = price;

		}

		public string GetInfo()
		{

			return string.Format(name + " " + rate + " " + price);
		}
		
		public override string ToString()
		{
			return $"\n_-_-_-_-_-_Info of the car driver_-_-_-_-_-_: \nName: {name}\nResidence: {Residence}\nRate: {rate}\nPrice: {price}";
		}
		public override bool Equals(object obj)
		{
			DriverCar mobj = obj as DriverCar;
			return mobj != null && Object.Equals(this.Name, mobj.Name) && Object.Equals(this.Rate, mobj.Rate) && Object.Equals(this.Price, mobj.Price);
		}
	};
}
