using System.Security.Cryptography.X509Certificates;

namespace CovarianceWithDelegates
//Covariance can be applied on delegate, generic, array, interface, etc.
{
    public delegate Small CovarDel(Big mc);
    public class Small
    {

    }
    public class Big :Small
    {

    }
    public class Bigger : Big
    {

    }

    internal class CovarDelegates
    {
        public static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");
            return new Big();
        }

        public static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");

            return new Small();
        }
        static void Main(string[] args)
        {
            CovarDel del = Method1;

            Small sm1 = del(new Big());

            del = Method2;

            Small sm2 = del(new Big());

            //Covariance allows you to use a derived class where a base class is expected (rule: can accept big if small is expected).
            //delegate expects a return type of small (base class) but we can still assign Method1 that returns Big (derived class) and also Method2 that has same signature as delegate expects.
            //Thus, covariance allows you to assign a method to the delegate that has a less derived return type.
        }
    }
}