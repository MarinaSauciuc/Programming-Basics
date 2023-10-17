using System.Collections.Generic;

namespace Queues
//C# includes generic Queue<T> and non-generic Queue collection.
//recommended to use the generic Queue<T> collection.
//Queue is a special type of collection that stores the elements in FIFO style(FIRST IN FIRST OUT)
//the reverse of STACK
{
    internal class Queues
{
        static void Main(string[] args)
        {
            //1. CREATE the Queue
            Queue<int> numbers = new Queue<int>();
            //Enqueue() method to add
            //!!!!! Cannot use collection-initializer syntax UNLIKE other collections
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(4);



            //Dequeue() method returns the first element and removes it from the queue
            Console.WriteLine("Total count is " + numbers.Count);
            Console.WriteLine(numbers.Dequeue());
            Console.WriteLine("Total count is " + numbers.Count);
            //Peek() method returns the first element but it doesnt remove it from a queue
            Console.WriteLine(numbers.Peek());
        }
    }
}