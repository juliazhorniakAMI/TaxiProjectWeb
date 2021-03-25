using System;
using System.Collections.Generic;
using System.Text;
using TaxiProject_2._1.Repository;
namespace TaxiProject_2._1.Models
{


    public class Person : Entity
    {


        public string Residence { get; set; }
        protected string name;
        public string Name { get { return name; } set { name = value; } }
        public int Rate { get; set; }
        public Person(string name = "")
        {
            Residence = "LVIV";
            this.name = name;
        }
        public string GetInfo() { return ""; }
    }
}
