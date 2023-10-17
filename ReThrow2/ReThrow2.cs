namespace ReThrow2
{
    internal class ReThrow2
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
                throw ex; //If you re-throw an exception using exception parameter (throwex) then it will not preserve the original exception and creates a new exception. 
                //Hence, in this example, the output will NOT display Method2 in stack trace as we re-throw exception in Method1() using throw ex.
                //So, never throw an exception using throw <exception parameter>.
            }
        }

        static void Method2()
        {
            string str = null;
            try
            {
                Console.WriteLine(str[0]);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}