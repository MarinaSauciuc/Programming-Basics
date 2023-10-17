using System;

namespace SortedLists
//generic SortedList<TKey, TValue>
//non-generic SortedList
//It is recommended to use generic SortedList<TKey, TValue> because it performs faster and less error-prone
// like a Dictionary but Sorts elements as soon as they are added. 

    //A key must be unique and cannot be null.
    //A value can be null or duplicate.
    //It uses less memory than SortedDictionary<TKey, TValue>.
{
    internal class SortedLists
    {
        static void Main(string[] args)
        {
            //1. CREATING
            SortedList<int, string> numberNames = new SortedList<int,string>();
            numberNames.Add(3, "Three");
            numberNames.Add(5, "Five");
            numberNames.Add(2, "Two");
            numberNames.Add(1, "One");
            numberNames.Add(4, "Four");

            //2.ACCESING
            Console.WriteLine(numberNames[1]); //output: One
            Console.WriteLine(numberNames[2]); //output: Two
            Console.WriteLine(numberNames[3]); //output: Three

            Console.WriteLine();

            //3. ITERATING
            foreach (var i in numberNames) //its a pair of key and value so we use var
                                           //or
                                           // foreach (KeyValuePair <int, string> i in numberNames)
            {
                Console.WriteLine(i);
            }

            SortedList<string, string> capitals = new SortedList<string, string>()
            {
                { "London", "UK" },
                { "Bucharest", "Romania" },
                { "Mumbai", "India" }
            };

            Console.WriteLine();

            foreach (KeyValuePair<string, string> kvp in capitals) 
            { 
            Console.WriteLine("key is: {0}, value is: {1}", kvp.Key, kvp.Value);
            }

        }
    }
}