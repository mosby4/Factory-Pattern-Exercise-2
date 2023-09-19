﻿ namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            String userInput;
            bool correctInput;
            do {
                Console.Clear();
                correctInput = true;
                Console.WriteLine("Hello, What database would you like to work wiht: sql, mongo, list?");

                userInput = Console.ReadLine();
                if(userInput != "sql" && userInput != "mongo" && userInput != "list")
                    {
                     correctInput = false;
                    Console.WriteLine("Input not accepted");
                    Thread.Sleep(1000);
                    }
            }
            while (!correctInput);
            Console.Clear();

            

            IDataAccess customDatabase = DataAccessFactory.GetDataAccessType(userInput);
            Console.WriteLine($"{customDatabase}");
        }
    }
}
/*In one solution, you will need to create some new types.
A class called Product with 2 properties, Name and Price
An interface called IDataAccess with 2 methods, LoadData() and SaveData()
3 classes that implement the interface and its members (the methods), ListDataAccess, SQLDataAccess, and MongoDataAccess
Last you will need to create a class called DataAccessFactory


The 3 classes that implement your IDataAccess interface should provide implementations for the 2 methods 
LoadData(): Just print to the console “I am reading data from {whatever type class this is, i.e: list, SQL database, mongo database}” and then return a new list of Product.
Done SaveData(): Print “I am saving data from a {whatever type} database” to the console


Once those 3 classes have the methods implemented, you will need to fill out your factory
Done--This shall be a public static class
Done--There will be one method with the following signature: public static IDataAccess GetDataAccessType(string databaseType)
Done--Switch on the databaseType variable
If a user types in list this should return a new instance of the ListDataAccess
If a user types in sql this should return a new instance of the SQLDataAccess
If a user types in mongo this should return a new instance of the MongoDataAccess


Lastly in the Main()
Done--Ask the user what database they want to use: a List, SQL, or Mongo
Done--Store their response in a variable
Done--Call your factory method and pass in what the user types and store what your factory method returns in an IDataAccess variable
Call the LoadData and SaveData methods of the IDataAccess variable
Run the program a few times using the different types.
*/