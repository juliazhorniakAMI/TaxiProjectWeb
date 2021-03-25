using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiProject_2._1.Models
{
    public class Bus : Vehicle
    {

        public Bus(string make = "", int number = 0, string color = "", int MaxSpeed = 0,string img="") : base(make, number, color, MaxSpeed,img)
        { }

        public override string ToString()
        {
            return $"\n___________Bus information____________:\nMake: {make}\nNumber: {number}\nColor: {color}\nMaxSpeed: {maxSpeed}";
        }
    }
}
