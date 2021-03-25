using System;
using TaxiProject_2._1.Models;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace TaxiProject_2._1.Repository
{
   public class DriverBusRepository : Repository<DriverBus>
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public DriverBusRepository() 
        {
            base.ReadFromStorage();
        }



        public bool Add(DriverBus b)
        {
            return AddRep(b);
        }
        public override void ChangeRateVehicle(int index, int rating)
        {

            entity[index].Rate = rating;

        }

        public override void ReadFromStorage()
        {
            try
            {
                List<string> lines = new List<string>();
                string name;
                int rate;
                int price;
                using (StreamReader sr = new StreamReader("Driverbus.txt"))
                {

                    while (!sr.EndOfStream)
                    {
                        lines.Add(sr.ReadLine());

                    }
                    sr.Close();
                }
                for (int i = 0; i < lines.Count; i++)
                {

                    string[] subs = lines[i].Split(' ');
                    name = subs[0];
                    rate = Convert.ToInt32(subs[1]);

                    price = Convert.ToInt32(subs[2]);
                    DriverBus dr = new DriverBus(name, rate, price);

                    Add(dr);
                }

            

               
              

        }
            catch (Exception e)
            {
                log.Info(e.Message);
               // Console.WriteLine(e.Message);
            }





}
        public override void WriteToStorage()
        {




            try
            {


                using (StreamWriter sw = new StreamWriter("Driverbus.txt", false))
                {

                    foreach (DriverBus o in entity)
                    {
                        sw.WriteLine(o.GetInfo());//адреси зберігає

                    }
                }

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
}