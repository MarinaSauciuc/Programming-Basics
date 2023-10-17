namespace Stacks
//C# includes the generic Stack<T> and non-generic Stack collection classes.
// !! recomended the use of generic
//Stack is a special type of collection that stores elements in LIFO style (LAST IN FIRST OUT).

{
    internal class Stacks
    {
        static void Main(string[] args)
        {
            //1. CREATE the Stack
            Stack<int> numbers = new Stack<int>();
         //PUSH() method to add
         //!!!!! Cannot use collection-initializer syntax UNLIKE other collections
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);

            //create Stack from an array
            //int[] arr = new int[]{ 1, 2, 3, 4};
            //Stack<int> myStack = new Stack<int>(arr);
         
         //Pop() method returns the last element and removes it from a stack.
            Console.WriteLine("Total count is " + numbers.Count);
            Console.WriteLine(numbers.Pop());
            Console.WriteLine("Total count is " + numbers.Count);
         //Peek() method returns the last element but it doesnt remove it from a stack.
            Console.WriteLine(numbers.Peek());

        }
    }
}