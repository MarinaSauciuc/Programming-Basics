namespace ExceptionHandling
////try
//{
//    // put the code here that may raise exceptions
//}
//catch
//{
//    // handle exception here
//}
//finally
//{
//    // final cleanup code
//}

{
    internal class ExceptionHandling
    {
        static void Main(string[] args)
        {
            //Any suspected code that may raise exceptions should be put inside a try{ } block
            //A try block must be followed by catch or finally or both blocks.
            // !!! The try block without a catch or finally block will give a compile-time error.
            try
            {
                Console.WriteLine("Enter a number");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Squre of {num} is {num * num}");
            }

            //The catch block is an exception handler block where you can perform some action such as logging and auditing an exception.
            //catch block can pe parameterLESS BUT IT WONT give details of the exception
            catch (Exception ex) 
            {
                Console.WriteLine("Error encountered: " + ex.Message);
            }

            //finally block is an OPTIONAL block
            //The finally block will ALWAYS be executed whether an exception raised or not. Usually, a finally block should be used to release resources
            //in the finally block, we display a message about what to do after running a program.
            //Multiple finally blocks are not allowed.
            //Also, the finally block cannot have the return, continue, or break keywords. It doesn't let control to leave the finally block.

            finally
            {
                Console.WriteLine("Re-try with different number");
            }

            


            
        }
    }
}