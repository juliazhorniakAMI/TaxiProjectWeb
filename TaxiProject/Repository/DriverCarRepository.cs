using System;
using System.Collections.Generic;
using System.Text;
using TaxiProject_2._1.Models;
using System.IO;

namespace TaxiProject_2._1.Repository
{
    public class DriverCarRepository : Repository<DriverCar>
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public DriverCarRepository()
        {
            base.ReadFromStorage();
        }



        public override void Add(DriverCar b)
        {
            AddRep(b);
        }


        public override void ReadFromStorage()
        {

            try
            {
                List<string> lines = new List<string>();
                string name;
                int rate;
                int price;
                using (StreamReader sr = new StreamReader(@"C:\c#\WebApplication1\TaxiAdmin\bin\Debug\netcoreapp3.1\Drivercar.txt"))
                {

                    while (!sr.EndOfStream)
                    {
                        lines.Add(sr.ReadLine());

                    }
                    sr.Close();
                }
                for (int i=0; i < lines.Count; i++)
                {

                    string[] subs = lines[i].Split(' ');
                    name = subs[0];
                    rate = Convert.ToInt32(subs[1]);

                    price = Convert.ToInt32(subs[2]);
                    DriverCar dr = new DriverCar(name, rate, price);

                    Add(dr);
                }






            }
            catch (Exception e)
            {
                log.Error(e.Message);
               // Console.WriteLine(e.Message);
            }





        }
        public override void ChangeRateVehicle(int index, int rating)
        {

            entity[index].Rate = rating;

        }
        public override void WriteToStorage()
        {




            try
            {


                using (StreamWriter sw = new StreamWriter(@"C:\c#\WebApplication1\TaxiAdmin\bin\Debug\netcoreapp3.1\Drivercar.txt", false))
                {

                    foreach (DriverCar o in entity)
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
