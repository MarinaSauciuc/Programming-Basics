namespace DoWhileLoop
{
    internal class DoWhileLoop
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine($"\nThe value of i is {i}");
                i--;
            }
            while (i >0); //trebuie mereu ;

            //do while vs while

            int j = 0;
            while(j>0)
            {
                Console.WriteLine($"The value of j is {j}");
                j--;
            }


        }

        
    }
}