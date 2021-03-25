using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxiProject_2._1.Models;
using TaxiProject_2._1.Repository;
namespace WebApplication1.Controller
{
    public class Common
    {

        public List<Taxi> taxi { get; set; }
        public List<DriverBus> drbus { get; set; }
        public List<DriverCar> drcar { get; set; }

        public List<Bus> bus { get; set; }
    }
}
