using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiProject_2._1.Repository;
using TaxiProject_2._1.Models;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace TaxiProjectUser
{

	class Program
	{



		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		static void Main(string[] args)
		{



			Command com = new Command();



			while (true)
			{
				Console.WriteLine("                             - - - ->>>>>>TAXI SERVICE: ");
				Console.WriteLine("______Choose an option_______: ");
				Console.WriteLine("1. Show available taxi");
				Console.WriteLine("2. Show information of taxi drivers");
				Console.WriteLine("3. Rent a taxi");
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

				else
				{
					break;
				}



			}
			Console.ReadKey();
		}
	}
}
