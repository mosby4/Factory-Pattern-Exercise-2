using System;
using FactoryPatternExercise2;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess 
	{
		public ListDataAccess()
		{
		}
        public static List<Product> products = new List<Product>()
        {
            new Product() {Name =" sugar Mapel", price =600 },
            new Product() { Name = "Weeping Willow", price = 450 },
            new Product () {Name = "Ficus", price = 50 },

        };
        public List<Product> LoadData()
        {
            Console.WriteLine( "I am reading data from ListDataAccess.");
            throw new NotImplementedException();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a {   } to the console.");
            throw new NotImplementedException();
        }
    }
}

