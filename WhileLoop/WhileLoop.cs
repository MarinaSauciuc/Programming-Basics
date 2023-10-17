namespace WhileLoop
{
    internal class WhileLoop
    {
        static void Main(string[] args)
        {
            int i = 0; //intialize
            while (i<=8) //conditie
            {
                Console.WriteLine($"\nThe value of i is {i}");
                i++; //iterator / incrementor
            }

            int j = 0;
            while(true)
            {
                Console.WriteLine($"The value of j is {j}");
                j++;
                if(j>100)
                {
                    break;
                }
            }
        }
    }
}