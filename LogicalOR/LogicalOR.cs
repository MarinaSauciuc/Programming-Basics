namespace LogicalOR
{
    //Bool logical OR is | (ONLY ONE |)
    internal class LogicalOR
    {
        static bool SecondOperand()
        {
            Console.WriteLine("Second Operand is evaluated");
            return true;
        }
        static void Main(string[] args)
        {
            bool a = true | SecondOperand();
            Console.WriteLine(a);
            // Output:
            // Second Operand is evaluated. //second operand is evaluated even tho the first operation is true hence everythign true
            // True

            bool b = false | SecondOperand();
            Console.WriteLine(b);
            // Output:
            // Second Operand is  evaluated.
            // True
        }
        //!!! The | operator evaluates both operands even if the left-hand operand evaluates to true,
        //!!! so that the operation result is true regardless of the value of the right-hand operand.
    }
}