namespace NestedCatch
{
    internal class NestedCatch
    {
        static void Main(string[] args)
        {
            var divider = 0;

            try
            {
                try
                {
                    int result = 100 / divider;
                }

                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Inner");
                }
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Outer");
                //In the above example, an exception of type DivideByZeroException will be raised.
                //Because an inner catch block handles only the NullReferenceTypeException, it will be handle by an outer catch block.
            }

        }
    }
}