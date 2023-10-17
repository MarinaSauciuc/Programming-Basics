namespace PassingDelegateAsParameter
{
    public delegate void MyDelegate(string message); // declaring delegate
    internal class PassingDelegate
    {
        static void Main(string[] args)
        {
            //first, we need to create the object of the delegate and set the method target
            MyDelegate del = ClassA.MethodA; 

            //calling the delegate via the created method
            InvokeDelegate(del);
        }

        static void  InvokeDelegate(MyDelegate del) //second, we need to create the method whose parameter would be the delegate
        {
            Console.WriteLine("Hey, I am the Method A that goes to the delegate and called by InvokeDelegate via delegate parameter!");
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