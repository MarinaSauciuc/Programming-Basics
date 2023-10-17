namespace Delegates
//A delegate is a reference to a method.
//A delegate can be seen as a placeholder for a/some method(s).
//every once in a while you might feel the need to send a method as a parameter to another method, and that's when you'll need delegates.

//delegate SYNTAX: [access modifier] delegate [return type] [delegate name]([parameters])
{
    public delegate void MyDelegate(string message); //can be created outside of the program
    internal class Delegates
    {
        static void Main(string[] args)
        {
            //now we need to set the target method AKA the method we will use delegate on
            //After declaring a delegate, we need to set the target method
            //We can do it by creating an object of the delegate using the new keyword and passing a method whose signature matches the delegate signature.
            
            MyDelegate del = new MyDelegate(ClassA.MethodA); //we need to use a method in another methdo, need to specify the class
            //MyDelegate del = MethodA. //if we didnt had method in another class
            //MyDelegate del = ClassA.MethodA;

            //invoking the delegate
            del.Invoke("Hello World");

            //You can also set the target method by assigning a method directly without creating an object of delegate
            del = ClassB.MethodB;
            del("Hello World");

        }
    }

    public class ClassA
    {
        public static void MethodA(string message) //the method we will use in delegate need to have same signature as the delegate AKA string message
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }
}