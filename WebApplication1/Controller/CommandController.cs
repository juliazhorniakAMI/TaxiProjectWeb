using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaxiProject_2._1.Models;
using TaxiProject_2._1.Repository;
using WebApplication1.Controller;
namespace TaxiAdmin
{
   public class CommandController:Controller
    {
        public IRepository<Taxi> taxiRepository = new TaxiRepository();
        public IRepository<Bus> busRepository = new BusRepository();
        public IRepository<DriverCar> driverCARRepository = new DriverCarRepository();

        public IRepository<DriverBus> driverBUSRepository = new DriverBusRepository();

       
      
    

        public ViewResult WriteAllDrivers()
        {
            Common list3 = new Common();
            list3.taxi = taxiRepository.Ent;
            list3.bus = busRepository.Ent;


            
            return View(list3);
          

        }

        public ViewResult Mazda()
        {
            Common list3 = new Common();
            list3.taxi = taxiRepository.Ent;
       




            return View(list3);


        }
        public ViewResult Audi()
        {
            Common list3 = new Common();
            list3.taxi = taxiRepository.Ent;
      





            return View(list3);


        }
        public ViewResult Mersedes_Benz()
        {
            Common list3 = new Common();

         
            list3.bus = busRepository.Ent;




            return View(list3);


        }
        public ViewResult Nissan()
        {
            Common list3 = new Common();

        
            list3.bus = busRepository.Ent;



            return View(list3);


        }
        public ViewResult InfoBus()
     {
            Common list3 = new Common();
            list3.drbus = driverBUSRepository.Ent;
            list3.bus = busRepository.Ent;
            return View(list3);


        }
        public ViewResult InfoCar()
        {
            Common list3 = new Common();
            list3.drcar = driverCARRepository.Ent;
            list3.taxi = taxiRepository.Ent;
            return View(list3);


        }
    }
}



