namespace ConditionalOR
{
    //the conditional operator is || (the double ||)
    //used in SHORT-CIRCUIT evaluation

    //In the following example, the right-hand operand of the || operator is a method call,
    //which isn't performed if the left-hand operand evaluates to true (hence short circuit):
    internal class ConditionalOR
    {
        static bool SecondOperand()
        {
            Console.WriteLine("Second Operand is evaluated");
            return true;
        }
        static void Main(string[] args)
        {
            bool a = true || SecondOperand();
            Console.WriteLine(a);
            // Output:
            // True    //because the first satatement is true, it DOESNT need to evaluate the second

            Console.WriteLine(); //just added a new line

            bool b = false || SecondOperand();
            Console.WriteLine(b);
            // Output:
            // Second operand is evaluated. //because the first satatement is false, it WILL need to evaluate the second
            // True
        }
    }
}