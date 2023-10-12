using System;
namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {
        }
        public static List<Product> products = new List<Product>()
            {
                new Product() {name = "XBOX", price =1600 },
                new Product() { name = "Advanced Controller", price = 450 },
                new Product () {name = "xbox adaptor cord", price = 50 },
            };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from ListDataAccess.");
            return products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a MongoDataAccess to the console.");
        }
        
   
    }
}

