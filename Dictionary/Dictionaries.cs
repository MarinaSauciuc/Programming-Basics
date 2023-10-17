namespace Dictionaries
//The Dictionary<TKey, TValue> is a generic collection that stores key-value pairs in no particular order.
//it DOESNT SORT
//Keys must be unique and cannot be null.
//Values can be null or duplicate.

        //Elements are stored as KeyValuePair<TKey, TValue> objects.
{
    internal class Dictionaries
    {
        static void Main(string[] args)
        {
            //1. CREATING
            Dictionary<int, string> numberNames = new Dictionary<int, string>();
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

            Dictionary<string, string> capitals = new Dictionary<string, string>()
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