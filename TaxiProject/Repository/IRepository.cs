using System;
using TaxiProject_2._1.Models;
using System.Collections.Generic;
using System.Text;

namespace TaxiProject_2._1.Repository
{
   public interface IRepository<T>
    {
  
        List<T> Ent { get;  }
        void ReadFromStorage();
        void WriteToStorage();
        void AddRep(T en);
        void Add(T en);
        void deleteByIndex(int ind);
        void ChangeRateVehicle(int index, int rating);
        void ChangeNameTaxi(int index, string name);
        void ChangeImgTaxi(int index, string name);

    }
}
