using System.Threading.Channels;

namespace ValueType
{
    internal class Value
    {
        static void Main(string[] args)
        {
            int y = 300;

            Console.WriteLine(y);
            ChangeValue(y);
            Console.WriteLine(y);
        }

        static void ChangeValue(int x)
        {
             x = 100;
            Console.WriteLine(x);
        }

        //!! When you pass a value-type variable from one method to another, it creates a separate copy of a variable in another method.
        //If value got changed in the one method, it wouldn't affect the variable in another method.
        // aka a VALUE TYPE LASTS ONLY INSIDE ITS OWN METHOD
        //basically, y displays as the initial value =300 for the first method, for the calling method y is switched with x -->
        //-->hence y becomes = x =100. But when we go back to calling y again, it maintains its initial value
    }
}