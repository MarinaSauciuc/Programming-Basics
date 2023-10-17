namespace ContravarianceWithDelegates
//Contravariance allows a method with the parameter of a base class to be assigned to a delegate that expects the parameter of a derived class.
{
    delegate Small covarDel(Big mc);
    public class Small
    {

    }
    public class Big : Small
    {

    }
    public class Bigger : Big
    {

    }
    internal class CONTRAvarDelegates
    {
        static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");
            return new Big();
        }
        static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");
            return new Small();
        }

        static Small Method3(Small sml)
        //Method3 has a parameter of Small class whereas delegate expects a parameter of Big class.
        //Still, you can use Method3 with the delegate.
        {
            Console.WriteLine("Method3");

            return new Small();
        }
        static void Main(string[] args)
        {
            covarDel del = Method1;
            del += Method2;
            del += Method3;

            Small sm = del(new Big());
        }
    }
    
}