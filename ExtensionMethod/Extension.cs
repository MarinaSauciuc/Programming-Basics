using System.Runtime.CompilerServices;

namespace ExtensionMethod

//Extension methods, as the name suggests, are additional methods. 
//The extension methods have a special symbol in intellisense of the visual studio, so that you can easily differentiate between class methods and extension methods.
//the symbol is a down arrow

//An extension method is actually a special kind of static method defined in a static class.
//To define an extension method, first of all, define a static class.
{
    //example 1 class
    public static class IntExtensions
    {
        //inside the static class, we need to define  a static method as an extension method
        //first parameter of the extension method specifies the type on which the extension method is applicable.
        //So the first parameter must be INT preceded with the THIS modifier.
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }

    //example 2 and 3 class
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Length;
        }
    }


    internal class Extension
    {
        static void Main(string[] args)
        {
            //example 1
            int i = 10;
            bool result = i.IsGreaterThan(200);
            Console.WriteLine($"The result of {i} being higher is: {result}");

            //example 2
            string word = "homeeeeeeeeee";
            int result2 = word.WordCount();
            Console.WriteLine($"The result for the counted letters in the {word} word is: {result2}");

            Console.WriteLine();
            
            //example 3
            Console.WriteLine("Please write a word:");
            string input = Console.ReadLine();
            int result3 = input.WordCount();
            Console.WriteLine($"The number of letters for your word \"{input}\" is: {result3}");

        }

        //Now, you can include the _Extension_Methods namespace wherever you want to use this extension method: using _Extension_Methods
        //The only difference between a regular static method and an extension method is that
        //the first parameter of the extension method specifies the type that it is going to operator on, preceded by the this keyword.
    }
}