namespace ArraySingleDimensional
{
    internal class SingleDimensional
    {
        static void Main(string[] args)
        {
            //Declaration and later initialization
            //int[] numbers; <- declaration
            //numbers = new int[] { 1, 6, 69, 16, 25, 5 }; <- late initialization


            //short syntax
            int[] numbers = { 1, 6, 69, 16, 25, 2 };

            //accesing the array elements
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[5]);

            //accesing the array using FOR loop
            Console.WriteLine("The FOR loop:");
            for(int i =0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
            
            //accesing the array using FOREACH loop
            Console.WriteLine("Original Array");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            //Sorted Array
            Console.WriteLine("Sorted Array");
            Array.Sort(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            //ReverseArray
            Console.WriteLine("Reversed Array");
            Array.Reverse(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("Test Lambda");
            Array.ForEach<int>(numbers, n => Console.WriteLine(n));

            Console.WriteLine("Test Lambda 2");
            Array.Reverse(numbers);
            Array.ForEach<int>(numbers, n => Console.WriteLine(n));

        }
    }
}