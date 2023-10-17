using System.Threading.Channels;

namespace StringReferenceType
{
    internal class String
    { 

        static void Main(string[] args)
        {
            string name = "Bill";
            Console.WriteLine(name);

            ChangeReference(name);

            Console.WriteLine(name);
        }

        static void ChangeReference(string name)
        {
            name = "Steve";
            Console.WriteLine(name);
        }
        //String is a reference type, but it is IMMUTABLE
        //It means once we assigned a value, IT CANNOT BE CHANGED

        //If we change a string value, then the compiler creates a new string object in the memory and point a variable to the new memory location.
        //So, passing a string value to a function will create a new variable in the memory, and any change in the value in the function WILL NOT be reflected in the original value
        //That occupies memory so --> use StringBuilder
    }
}