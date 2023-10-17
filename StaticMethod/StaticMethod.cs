using System.Diagnostics.Metrics;

namespace StaticMethod
{
    internal class StaticMethod
    {
        static int counter = 0; //STATIC VARIABLE
        string name = "Demo Program"; 

        static void Display(string text) //STATIC METHOD
        {
            Console.WriteLine($"This is your text: {text}");

        }

        public void SetRootFolder(string path)
        {

        }

        static void Main(string[] args)
        {
            counter++;
            Display("Hello World");

            //errors
            //name = "test"; //name is NOT a static member
            //SetRootFolder("C:\\MyProgram"); //SetRootFolder is NOT a static method

            //O metoda statica poate apela DOAR alte METODE STATICE si accesa DOAR membrii statici
        }
    }
}