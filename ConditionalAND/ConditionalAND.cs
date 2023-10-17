namespace ConditionalAND
{
    //the conditional operator is && (the double &&)
    //used in SHORT-CIRCUIT evaluation

    //In the following example, the right-hand operand of the && operator is a method call,
    //which isn't performed if the left-hand operand evaluates to false (hence short circuit):
    internal class ConditionalAND
    {
        static bool SecondOperand()
        {
            Console.WriteLine("Second Operand is evaluated");
            return true;
        }
        static void Main(string[] args)
        {
            bool a = false && SecondOperand();
            Console.WriteLine(a);
            // Output:
            // False    //because the first satatement is false, it DOESNT need to evaluate the second

            bool b = true && SecondOperand(); 
            Console.WriteLine($"\n{b}");
            // Output:
            // Second operand is evaluated. 
            // True

        }
    }
}