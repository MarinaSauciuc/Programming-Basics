namespace LogicalNegationUnaryOperator
{
    // the unary operator used for negation is !
    internal class LogicalNegation
    {
        static bool passed = true;// we need static field so we can use it in static method

        static void Main(string[] args)
        {
            bool failed = false;//we dont need this field to be static cause its already in a static method
            Console.WriteLine($"The opposite of passed - true is: {!passed}");
            Console.WriteLine($"The opposite of failed - false is: {!failed}");
        }
    }
}