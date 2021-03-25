using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiProject_2._1.Models;
using TaxiProject_2._1.Repository;
using TaxiAdmin;

namespace UnitTestProject3
{
    [TestClass]
    public class CommandTest
    {
        [TestMethod]
        public void Rep_Check_IsEmpty_False()
        {
          var taxiRepository = new TaxiRepository();
          var busRepository = new BusRepository();
          var driverCARRepository = new DriverCarRepository();

          var driverBUSRepository = new DriverBusRepository();

            Assert.IsNotNull(taxiRepository);
            Assert.IsNotNull(busRepository);
            Assert.IsNotNull(driverBUSRepository);
            Assert.IsNotNull(driverCARRepository);
        }

        [TestMethod]
        public void Rep_DeletByIndex_Equal_True()

        {

          
         
            var taxiRepository = new TaxiRepository();
           
            var expected = new List<Taxi>() { new Taxi("Audi", 1232, "red", 222, "/img/audi.jpg") };
            taxiRepository.deleteByIndex(1);
          
         

            CollectionAssert.AreEqual(expected,taxiRepository.Ent);
          

        }
        [TestMethod]
        public void Rep_ChangeRating_Equal_True()

        {



            var driverRepository = new DriverCarRepository();
            driverRepository.ChangeRateVehicle(1, 3);

            var expected = 3;
            var result = driverRepository.Ent[1].Rate;


            Assert.AreEqual(expected, result);


        }
        [TestMethod]
        public void Rep_Add_Equal_True()

        {

            var driverRepository = new DriverCarRepository();
            DriverCar d = new DriverCar("Yura", 4, 140);
            driverRepository.Add(d);
           

            var expected = new List<DriverCar>() { new DriverCar("Ivan", 5 ,150),new DriverCar("Pavlo", 2, 240), new DriverCar("Yura", 4, 140) };



            CollectionAssert.AreEqual(expected, driverRepository.Ent);


        }


    }

    


 }

