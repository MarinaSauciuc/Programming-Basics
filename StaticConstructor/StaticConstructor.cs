using System.Diagnostics;

namespace StaticConstructor
{
    internal class StaticConstructor
    {
        static void Main(string[] args)
        {
            StopWatch.DisplayInfo(); // static constructor called here
            StopWatch.DisplayInfo(); // none of the constructors called here

            //StopWatch sw1 = new StopWatch(); // First static constructor and then instance constructor called 
            //StopWatch sw2 = new StopWatch();// only instance constructor called 
            //StopWatch.DisplayInfo();


            //static constructor gets called when the static method called for the first time.
            //Calling the static method second time onwards won't call a static constructor.


        }
    }

    public class StopWatch
    {
        static StopWatch() //STATIC constructor (doesnt need public, private, protected)
        {
            Console.WriteLine("Static constructor called");
        }

        public StopWatch() //instance constructor
        {
            Console.WriteLine("Instance constructor called");
        }

        public static void DisplayInfo()
        {
            Console.WriteLine("DisplayInfo called");
        }



    }
}