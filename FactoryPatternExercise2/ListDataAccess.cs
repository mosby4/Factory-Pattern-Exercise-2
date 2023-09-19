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
            new Product() {name = "Two Person Glamping Tent", price =900 },
            new Product() { name = " -45 Goose Down sleeping bag", price = 450 },
            new Product () {name = "Universal National Parks Pass", price = 50 },

        };
        public List<Product> LoadData()
        {
            Console.WriteLine( "I am reading data from ListDataAccess.");
            return products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a list to the console.");
           
        }
    }
}

