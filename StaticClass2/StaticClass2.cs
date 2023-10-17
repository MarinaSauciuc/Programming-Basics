using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace StaticClass2
{
    internal class StaticClass2
    {
        static void Main(string[] args)
        {
            
            int result = Calculator.Sum(10, 20); //just calling the static method, we DONT need to CREATE OBJECT
            Console.WriteLine($"The sum is {result}");

            var calcType = Calculator.type; // accessing static variable
            calcType = "addition"; //switching the variable
            
            Console.WriteLine($"The type is {calcType}");

        }

        public static class Calculator
        {
            public static string type = "arithmetic"; //ALL MEMBERS of a static class need to be STATIC, including VARIABLES

            public static int Sum(int num1, int num2) //ALL MEMBERS of a static class need to be STATIC, including METHODS
            {
                return num1 + num2;
                
            }

        }

       
    }
}