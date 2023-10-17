namespace ReThrow
{
    internal class ReThrow
    {
        static void Main(string[] args)
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                //The stack trace is a propriety of the exception that will give you the full detail of where exactly this exception occurred.
                Console.ReadLine();
            }
        }

        static void Method1()
        {
            try
            {
                Method2();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        static void Method2()
        {
            string str = null;
            try
            {
                Console.WriteLine(str[0]);
            }

            catch 
            {
                throw;
            }

        }
    }
}