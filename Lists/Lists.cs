using System.Collections;

namespace Lists
//the generic version of the ArrayList that comes under System.Collections.Generic namespace.
//List<T> can contain elements of the specified type.
//It provides compile-time type checking and doesn't perform boxing-unboxing because it is generic.
//List<T> performs faster and less error-prone than the ArrayList.
{
    internal class Lists
    {
        static void Main(string[] args)
        {
            //1. CREATE list
            List<int> numbers = new List<int>();
            //populating using Add() method
            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(7);

            //or

            var cities = new List<string>() 
            //adding elements through collection-initializer syntax.
            {
                "New York",
                "London",
                "Bucuresti"
            }; //dont forget the ;

            string[] popularCities = { "Tokyo", "Shibuya", "Paris" };// array

            cities.AddRange(popularCities); //adding array inside a List

            //2. ACCESING the List

            //a) individual elements

            Console.WriteLine(numbers[0]); 
            Console.WriteLine();

            //b) using foreach LINQ method
            numbers.ForEach(x => Console.WriteLine(x)); // => is called LAMBDA
            Console.WriteLine();

            //c) whole list

            for (int i = 0; i < cities.Count; i++) 
            {
                Console.WriteLine(cities[i]);
            }

            Console.WriteLine();

            //3. INSERT, REMOVE, CONTAINS
            numbers.Insert(0, 100); //at 0 index, add numbers 100
            numbers.Remove(2); // removes the first 2 from a list
            numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)
            numbers.Contains(10);
            Console.WriteLine(numbers.Contains(10));







        }
    }
}