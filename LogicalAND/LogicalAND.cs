namespace LogicalAND
{
    //Bool logical AND is & (ONLY ONE &)
    internal class LogicalAND
    {
        static bool SecondOperand()
        {
            Console.WriteLine("Second Operand is evaluated");
            return true;
        }
        static void Main(string[] args)
        {
            bool a = false & SecondOperand();
            Console.WriteLine(a);

            // Output:
            // Second operand is evaluated.  //second operand is evaluated even tho the first operation is false hence everythign false
            // False

            bool b = true & SecondOperand();
            Console.WriteLine(b);

            // Output:
            // Second operand is evaluated.
            // False

            bool conditional = false && SecondOperand();
            Console.WriteLine($"\nThe result of using conditional is {conditional}"); //with conditional, the second operator is not evaluted since first is false
        }
        //!!! The & operator evaluates both operands even if the left-hand operand evaluates to false,
        //!!! so that the operation result is false regardless of the value of the right-hand operand.
    }
}