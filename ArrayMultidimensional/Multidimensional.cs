namespace ArrayMultidimensional
{
    internal class Multidimensional
    {
        static void Main(string[] args)
        {
            //virgula + 1 = the dimension
            int[,] array2d; // two-dimensional array
            int[,,] array3d; // three-dimensional array
            int[,,,] array4d; // four-dimensional array

            array2d = new int[3, 2] //3 = row     2 = column
            {
                {1, 2 },
                {3, 4},
                {4, 5},
            };

            //accesing elements
            Console.WriteLine(array2d[0,0]);
            Console.WriteLine(array2d[1,0]);
            Console.WriteLine(array2d[1,1]);

        }
    }
}