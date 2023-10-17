using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace Events
{
    internal class Events
    {
        static void Main(string[] args) //SUBSCRIBER of the ProcessCompleted event.
        //The subscriber class must register to ProcessCompleted event and handle it with the method whose signature matches Notify delegate, as shown below.
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic(); //the delegate is in a class so we create the object from it's class
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.StartProcess();
        }

        // event handler
        //The bl_ProcessCompleted() method handles the event because it matches the signature of the Notify delegate.
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }
    }

    public delegate void Notify();  // create the delegate
    //Notify delegate specifies the signature for the ProcessCompleted event handler.
    //in thise case, the event handler method in subscriber class must have a void return type and no parameters.

    public class ProcessBusinessLogic //creating a class in which we can add the event that will be used by the delegate = PUBLISHER
    {
        public event Notify ProcessCompleted; // event

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // some code here..
            OnProcessCompleted();
        }


        protected virtual void OnProcessCompleted() //raise an event --> protected virtual method
        //Typically, to raise an event, protected and virtual method should be defined with the name On<EventName>.
        {
            //The OnProcessCompleted() method invokes the delegate using ProcessCompleted?.Invoke();.
            ProcessCompleted?.Invoke();
        }
    }
}