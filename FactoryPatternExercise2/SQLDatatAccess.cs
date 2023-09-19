using System;
namespace FactoryPatternExercise2
{
	public class SQLDatatAccess : IDataAccess
	{
		public SQLDatatAccess()
		{
		}
        public static List<Product> products = new List<Product>()
        {
            new Product() {name =" sugar Mapel", price =600 },
            new Product() { name = "Weeping Willow", price = 450 },
            new Product () {name = "Ficus", price = 50 },
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from ListDataAccess.");
            return products;
        }

        public void SaveData()
        {
            Console.WriteLine( "I am saving data from a SQL database to the console.");
        }
    }
}

