using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiProject_2._1.Repository;
using TaxiProject_2._1.Models;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace TaxiAdmin
{
	class Program
	{
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		//heelo


		static void Main(string[] args)
		{

			Command com = new Command();

			

			while (true)
			{
				Console.WriteLine("                             - - - ->>>>>>TAXI SERVICE: ");
				Console.WriteLine("______Choose an option_______: ");
				Console.WriteLine("1. Show available taxi");
				Console.WriteLine("2. Show information of taxi drivers");
				Console.WriteLine("3. Rent taxi or bus");
				Console.WriteLine("4. Exit");


				char user = 'p';
				try
				{
					user = Convert.ToChar(Console.ReadLine());
					if (!char.IsDigit(user))
					{
						throw new Exception("Not possible among options");

					}
				}

				catch (Exception e)
				{
					log.Error($"Error: {e.Message}");

				}





				if (user == '1')
				{
					com.Print();
					Console.WriteLine("\n");
					while (true)
					{
						Console.WriteLine("1 Add taxi cars \n");
						Console.WriteLine("2 Add taxi buses\n");
						Console.WriteLine("3 Exit\n\n");

						char user2;

						user2 = Convert.ToChar(Console.ReadLine());

						if (user2 == '1')
						{

							Console.WriteLine("Enter Make,number,color and max speed:\n");
							string make = Console.ReadLine();
							int number = Convert.ToInt32(Console.ReadLine());
							string color = Console.ReadLine();
							int MaxSpeed = Convert.ToInt32(Console.ReadLine());

							Taxi t = new Taxi(make, number, color, MaxSpeed);
							Console.WriteLine("Enter Driver name,rate and price:\n");
							string name = Console.ReadLine();
							int rate = Convert.ToInt32(Console.ReadLine());
							int price = Convert.ToInt32(Console.ReadLine());

							DriverCar d = new DriverCar(name, rate, price);
							com.AddTaxi(t);
							com.AddDriverCar(d);

						}
						else if (user2 == '2')
						{
							Console.WriteLine("Enter Make,number,color and max speed:\n");
							string make = Console.ReadLine();
							int number = Convert.ToInt32(Console.ReadLine());
							string color = Console.ReadLine();
							int MaxSpeed = Convert.ToInt32(Console.ReadLine());


							Bus t = new Bus(make, number, color, MaxSpeed);
							Console.WriteLine("Enter Driver name,rate and price:\n");
							string name = Console.ReadLine();
							int rate = Convert.ToInt32(Console.ReadLine());
							int price = Convert.ToInt32(Console.ReadLine());

							DriverBus d = new DriverBus(name, rate, price);
							com.AddBus(t);
							com.AddDriverBus(d);
						}
						else
						{
							break;
						}
					}

				}
				else if (user == '2')
				{
					com.WriteAllDrivers();
					Console.WriteLine("\n");
					while (true)
					{
						Console.WriteLine("A-- Show driver with max rating \n");
						Console.WriteLine("B--Change rating in a certain driver\n");
						Console.WriteLine("C-- Exit\n\n");

						char user2;

						user2 = Convert.ToChar(Console.ReadLine());

						if (user2 == 'A')
						{
							com.showRate();
						}
						else if (user2 == 'B')
						{
							com.changeRate();
						}
						else
						{
							break;
						}
					}

				}


				else if (user == '3')
				{
					com.RentTaxi();
				}
				else if (user == '4')
				{
					break;
				}
				else
				{

					log.Info("Incorrect value");
				}

			}
			Console.ReadKey();
		}




	}
}




