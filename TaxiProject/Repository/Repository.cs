using System;
using TaxiProject_2._1.Models;
using System.Collections.Generic;
using System.Text;



namespace TaxiProject_2._1.Repository
{
	public class Repository<Entity> : IRepository<Entity>
	{



		protected List<Entity> entity = new List<Entity>();






		
		public Repository()
		{
		
			ReadFromStorage();
		}
		public virtual void ReadFromStorage() { }
		public virtual void WriteToStorage() { }

		public List<Entity> Ent { get { return entity; }  }


		public void deleteByIndex(int ind)
		{
			entity.RemoveAt(ind);
		}
		public virtual void ChangeRateVehicle(int index, int rating)
		{


		}

		~Repository()
		{
			WriteToStorage();

		}

        public static explicit operator Repository<Entity>(List<Taxi> v)
        {
            throw new NotImplementedException();
        }

        public bool AddRep(Entity en)
		{
			entity.Add(en);
		
			
				WriteToStorage();
			


			return true;
		}

		public bool Add(Entity en) { throw new NotImplementedException(); }

	}
}

