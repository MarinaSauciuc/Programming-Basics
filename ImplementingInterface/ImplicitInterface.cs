namespace ImplicitImplementationInterface
{
    
    interface IFile //It is recommended to start an interface name with the letter "I" at the beginning 
                    //An interface can contain declarations of methods, properties, indexers, and events.
                    //Interface members are by default ABSTRACT AND PUBLIC
                    //You CANNOT apply access modifiers to interface members. (that changes from C# 8.0)
    {
        void ReadFile();
        void WriteFile();
    }

    class FileInfo : IFile //we implement the interface in the class using inheriting
        //we ABIDE BY THE CONTRACT/MUST implement the interface
    {
        public void ReadFile() //implicit implementation
                               //for IMPLICIT implementation, Interface members MUST BE implemented with the PUBLIC modifier;
        {
            Console.WriteLine("ReadingFile");
        }

        public void WriteFile()
        {
            Console.WriteLine("Writing File");
        }

    }


    internal class ImplicitInterface
    {
        static void Main(string[] args)
        {
            //creating objects
            
            IFile file1 = new FileInfo(); //we create objects of the FileInfo class and assign it to IFile type variable
            FileInfo file2 = new FileInfo(); //we create objects of the FileInfo class and assign it to FileInfo type variable.

            // !!!When interface implemented IMPLICITLY,
            // !!! you can access IFile members with the IFile type variables' names as well as FileInfo type variable.

            file1.ReadFile();
            file1.WriteFile();

            file2.ReadFile();
            file2.WriteFile();
        }
    }
}