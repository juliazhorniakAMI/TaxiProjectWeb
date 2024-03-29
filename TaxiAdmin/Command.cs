﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiProject_2._1.Models;
using TaxiProject_2._1.Repository;
namespace TaxiAdmin
{
    public class Command
    {
        public IRepository<Taxi> taxiRepository = new TaxiRepository();
        public IRepository<Bus> busRepository = new BusRepository();
        public IRepository<DriverCar> driverCARRepository = new DriverCarRepository();

        public IRepository<DriverBus> driverBUSRepository = new DriverBusRepository();



        public void AddTaxi(Taxi taxi)
        {
            taxiRepository.Add(taxi);
        }

        public void AddBus(Bus taxibus)
        {
            busRepository.Add(taxibus);
        }
        public void AddDriverCar(DriverCar driver)
        {
            driverCARRepository.Add(driver);
        }
        public void AddDriverBus(DriverBus driver)
        {
            driverBUSRepository.Add(driver);
        }
        public void Print()
        {
            taxiRepository.Ent.ForEach((o => { Console.WriteLine(o); }));
            busRepository.Ent.ForEach((o => { Console.WriteLine(o); }));


        }

        public void EditTaxi()
        {
            var nameoftaxi = "";
            int k;
            Console.WriteLine("Enter 1 if change a taxi and 0 for bus: \n");

            k = Convert.ToInt32(Console.ReadLine());




            if (k == 1)
            {
                for (int i = 0; i < taxiRepository.Ent.Count(); i++)
                {
                    Console.WriteLine(taxiRepository.Ent[i]);



                }
                Console.WriteLine("Write the name of a taxi car you want to change: \n");
                nameoftaxi = Console.ReadLine();
               
                Console.WriteLine("Write the url of img of a taxi car you want to change: \n");
                string link = Console.ReadLine();


                for (int i = 0; i < taxiRepository.Ent.Count(); i++)
                {

                    if (!(nameoftaxi.Contains("____NOT_AVAILABLE")))
                    {
                      

                        Console.WriteLine("Incorrect entering");
                        break;
                    }
                    if (nameoftaxi == taxiRepository.Ent[i].Make)
                    {
                        char[] tmp = new char[nameoftaxi.Length - 17];
                        for (int j = 0; j < nameoftaxi.Length - 17; j++)
                        {

                            tmp[j] = nameoftaxi[j];

                        }

                        string s = "";
                        foreach (var o in tmp) {

                            s += o;
                        }


                        taxiRepository.ChangeNameTaxi(i, s);
                        taxiRepository.ChangeImgTaxi(i, link);
                        taxiRepository.WriteToStorage();
                        break;

                    }
                }


            }
            else if (k==0)
            {
                for (int i = 0; i < busRepository.Ent.Count(); i++)
                {
                    Console.WriteLine(busRepository.Ent[i]);




                }
                Console.WriteLine("Write the name of a taxi bus you want to change: \n");
                nameoftaxi = Console.ReadLine();
                Console.WriteLine("Write the url of img of a taxi bus you want to change: \n");
                string link = Console.ReadLine();


                for (int i = 0; i < busRepository.Ent.Count(); i++)
                {

                    if (nameoftaxi == busRepository.Ent[i].Make)
                    {
                        char[] tmp = new char[nameoftaxi.Length - 17];
                        for (int j = 0; j < nameoftaxi.Length - 17; j++)
                        {

                            tmp[j] = nameoftaxi[j];

                        }

                        string s = "";
                        foreach (var o in tmp)
                        {

                            s += o;
                        }



                        busRepository.ChangeNameTaxi(i, s);
                        busRepository.ChangeImgTaxi(i, link);
                        busRepository.WriteToStorage();
                        break;

                    }
                }
            }



            
        }
       

        public void WriteAllDrivers()
        {
            for (int i = 0; i < taxiRepository.Ent.Count(); i++)
            {
                Console.WriteLine(driverCARRepository.Ent[i]);
                Console.WriteLine(taxiRepository.Ent[i]);



            }
            for (int i = 0; i < busRepository.Ent.Count(); i++)
            {
                Console.WriteLine(driverBUSRepository.Ent[i]);
                Console.WriteLine(busRepository.Ent[i]);



            }
        }




        public void showRate()
        {
            int max = driverCARRepository.Ent[0].Rate;
            int max2 = driverBUSRepository.Ent[0].Rate;
            int ind = 0;
            int ind2 = 0;
            for (int i = 1; i < driverCARRepository.Ent.Count(); i++)
            {
                int tmp = driverCARRepository.Ent[i].Rate;
                if (max < (tmp))
                {
                    max = tmp;
                    ind = i;
                }

            }
            for (int i = 1; i < driverBUSRepository.Ent.Count(); i++)
            {
                int tmp = driverBUSRepository.Ent[i].Rate;
                if (max2 < (tmp))
                {
                    max2 = tmp;
                    ind2 = i;
                }

            }
            if (driverBUSRepository.Ent[ind2] > driverCARRepository.Ent[ind])
            {
                Console.WriteLine("A driver with the highest rate is: \n");


                Console.WriteLine(driverBUSRepository.Ent[ind2]);
                //virtual method no (*Driver)
                Console.WriteLine("\n");

            }
            else
            {
                Console.WriteLine("A driver with the highest rate is:  \n");
                Console.WriteLine(driverCARRepository.Ent[ind2]);

                //virtual method no (*Driver)
                Console.WriteLine("\n");

            }


        }
        public void changeRate()
        {
            int rating;

            string name;

            int b;
            Console.WriteLine("Enter 1 if you want to change rate for cars and 0 for buses: \n");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 1 if you want to change rate for cars and 0 for buses: \n");
            Console.WriteLine("Enter the name of a driver whose rating you want to change :  \n");


            name = Console.ReadLine();
            if (b == 1)
            {
                for (int i = 0; i < driverCARRepository.Ent.Count(); i++)
                {
                    if ((driverCARRepository.Ent[i]).Name == name)
                    {
                        Console.WriteLine("Enter a rating from 1-5 to this driver:  \n");
                        rating = Convert.ToInt32(Console.ReadLine());


                        driverCARRepository.ChangeRateVehicle(i, rating);
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < driverBUSRepository.Ent.Count(); i++)
                {
                    if ((driverBUSRepository.Ent[i]).Name == name)
                    {
                        Console.WriteLine("Enter a rating from 1 - 5 to this driver:  \n");

                        rating = Convert.ToInt32(Console.ReadLine());
                        driverBUSRepository.ChangeRateVehicle(i, rating);
                        break;
                    }
                }

            }
        }
    }
}