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
        public void Rep_ChangeRating_Equal_True()

        {



            var driverRepository = new DriverCarRepository();
            driverRepository.ChangeRateVehicle(1, 3);

            var expected = 3;
            var result = driverRepository.Ent[1].Rate;


            Assert.AreEqual(expected, result);


        }
       


    }

    


 }

