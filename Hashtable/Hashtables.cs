using System.Collections;

namespace Hashtables
//The Hashtable is a non-generic collection that stores key-value pairs, similar to generic Dictionary<TKey, TValue> collection.
//Hashtable stores key-value pairs.
//Keys must be unique and cannot be null.
//Values can be null or duplicate.

//Elements are stored as DictionaryEntry objects.
{
    internal class Hashtables
    {
        static void Main(string[] args)
        {
            //1. CREATING
            Hashtable numberNames = new Hashtable();
            numberNames.Add(3, "Three");
            numberNames.Add(5, "Five");
            numberNames.Add(2, "Two");
            numberNames.Add(1, "One");
            numberNames.Add(4, "Four");

    //creating a dictionary using collection-initializer syntax
            var cities = new Hashtable()
            {
                { "UK", "London, Birmingham"},
                { "Romania", "Bucharest, Iasi" },
                { "India", "Mumbai, New Delhi"}
            };

            //2. ITERATING
            foreach (DictionaryEntry i in numberNames) //var doesnt work
            {
                Console.WriteLine("key is: {0}, value is: {1}", i.Key, i.Value);
            }
            
            Console.WriteLine();

            foreach (DictionaryEntry de in cities)
            {
                Console.WriteLine("key is: {0}, value is: {1}", de.Key, de.Value);
            }

            Console.WriteLine();

            //3.ACCESING
            Console.WriteLine(numberNames[1]); //output: One
            Console.WriteLine(numberNames[2]); //output: Two
            Console.WriteLine(numberNames[3]); //output: Three

            Console.WriteLine();


        //The Hashtable is a non - generic collection, so you must type cast values while retrieving it.
            string citiesOfUK = (string)cities["UK"]; //cast to string
            string citiesOfRomania = (string)cities["Romania"]; //cast to string

            Console.WriteLine(citiesOfUK);
            Console.WriteLine(citiesOfRomania);

           
        }
    }
}