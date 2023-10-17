namespace StaticClass
{
    internal class StaticClass
    {
        static void Main(string[] args)
        {
            var result = Calculator.Sum(10, 20);  //calling the static method, we DONT need to CREATE OBJECT
            Calculator.Store(result);

            var calcType = Calculator.Type; // accessing static variable
            Calculator.Type = "Scientific"; // assign value to static variable

            Console.WriteLine($"The type is {calcType}");
            Console.WriteLine($"The sum is {result}");
        }

        public static class Calculator
        {
            private static int resultStorage; //all the members of a static class need to be static
            public static string Type = "Arithmetic"; //all the members of a static class need to be static
            
            //methods
            public static int Sum (int num1, int num2) //all the members of a static class need to be static
            {
                return num1 + num2;
            }

            public static void Store (int result) //all the members of a static class need to be static
            {
                resultStorage = result;
            }
        }
    }
}