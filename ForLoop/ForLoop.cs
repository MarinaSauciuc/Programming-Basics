using System.Globalization;

namespace ForLoop
{
    internal class ForLoop
    {
        static void Main(string[] args)
        {
            for (int i = 0; i<=6; i++) //initializer, condition, interator (increment/decrement)
            {
                for (int j = i; j<8; j++)
                {
                    Console.WriteLine("Value of i is {0} and value of j is {1}", i, j);
                    //sau folosind string literal $
                    Console.WriteLine($"Value of is is {i} and value of j is {j}");

                }
                    


            }
        }
    }
}