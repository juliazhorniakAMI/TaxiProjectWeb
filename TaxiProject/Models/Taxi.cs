using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiProject_2._1.Models
{
    public class Taxi : Vehicle
    {
        public Taxi(string make = "", int number = 0, string color = "", int MaxSpeed = 0,string img="") : base(make, number, color, MaxSpeed, img)
        { }
        public override string ToString()
        {
            return $"\n___________Taxi information_____________:\nMake: {make}\nNumber: {number}\nColor: {color}\nMaxSpeed: {maxSpeed}";
        }

        public override bool Equals(object obj)
        {
            Taxi mobj = obj as Taxi;
            return mobj != null && Object.Equals(this.Make, mobj.Make) && Object.Equals(this.Number, mobj.Number) && Object.Equals(this.Color, mobj.Color) && Object.Equals(this.MaxSpeed, mobj.MaxSpeed) && Object.Equals(this.Img, mobj.Img);
        }

      
    }
}
