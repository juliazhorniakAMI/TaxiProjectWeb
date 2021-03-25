using System;
using TaxiProject_2._1.Models;
using System.Collections.Generic;
using System.IO;
using System.Text;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace TaxiProject_2._1.Repository
{
	

	public class TaxiRepository : Repository<Taxi>
	{
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		public TaxiRepository()
		{
			base.ReadFromStorage();
		}

		public bool Add(Taxi taxi)
		{
			return AddRep(taxi);
		}



		public override void ReadFromStorage()
		{
			

			try
			{
			
				List<string> lines = new List<string>();
				string make;
				int number;
				string color;
				int MaxSpeed;
				string img;

				using (StreamReader sr = new StreamReader("Taxi.txt"))
				{

					while (!sr.EndOfStream)
					{
						lines.Add(sr.ReadLine());

					}
					sr.Close();
				}
				for (int i=0;i<lines.Count;i++) {

					string[] subs = lines[i].Split(' ');
					make = subs[0];
					number = Convert.ToInt32(subs[1]);

					color = subs[2];
					
					MaxSpeed = Convert.ToInt32(subs[3]);
					img = subs[4];
					Taxi t = new Taxi(make, number, color, MaxSpeed,img);
					Add(t);


				}
			
				
				

			}
			catch (Exception e)
			{
				log.Error(e.Message);
				//Console.WriteLine(e.Message);
			}
		}

        public static explicit operator TaxiRepository(List<Taxi> v)
        {
            throw new NotImplementedException();
        }

        public override void WriteToStorage()
		{
			

			


			try
			{
				

				using (StreamWriter sw = new StreamWriter("Taxi.txt",false))
				{

					foreach (Taxi o in entity)
					{
						sw.WriteLine(o.GetInfo());//адреси зберігає

					}
					sw.Close();
				}

			}

			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

		}
	}
}
