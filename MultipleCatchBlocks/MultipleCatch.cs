namespace MultipleCatchBlocks

//we can use multiple catch blocks with different exceptions
//thsi way, we can display an appropriate message to the user, depending upon the error
{
    internal class MultipleCatch
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number to divide 100: ");

            try
            {
                decimal num =Convert.ToDecimal(Console.ReadLine());
                //or
                //int num = int.Parse(Console.ReadLine());

                decimal result = 100 / num;

                Console.WriteLine("100 / {0} = {1}", num, result);
            }
            catch (DivideByZeroException ex)
            {
                Console.Write("Cannot divide by zero. Please try again.");
            }
            catch (InvalidOperationException ex)
            {
                Console.Write("Invalid operation. Please try again.");
            }
            catch (FormatException ex)
            {
                Console.Write("Not a valid format. Please try again.");
            }
            catch (Exception ex) //general catch block for any other errors
            {
                Console.Write("Error occurred! Please try again.");
            }

            //WARNING!  --> cannot have both catch and catch(Exception ex) --> A parameterless catch block and a catch block with the Exception parameter are not allowed in the same try-catch statements, because they both do the same thing.
            //Also, parameterless catch block catch{ } or general catch block catch(Exception ex){ } must be the last block.
            //The compiler will give an error if you have other catch blocks after a catch{ } or catch(Exception ex) block
        }
    }
}