namespace DefaultInterfaceMethods
{
    interface IFile
    {
        void ReadFile();
        void WriteFile();

        public void DisplayName() //default method
                                  // it is an implemented method that appears from C# 8.0
                                  //The implementation will remain same for all the classes that implements the IFile interface.
                                  //a class DOES NOT inherit default methods from its interfaces;
                                  //SOOOO you cannot access the default method using the class instance.
        {
            Console.WriteLine("iFile"); //default behavior
        }
    }

    class FileInfo : IFile
    {
        public void ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        public void WriteFile()
        {
            Console.WriteLine("Writing File");
        }

        //the default method is already implemented in the interface so it doesnt need implementations here
    }
    internal class DefaultInterfaceMethods
    {
        static void Main(string[] args)
        {
            IFile file1 = new FileInfo();
            FileInfo file2 = new FileInfo();

            //The object FileInfo file2 ONLY has access to the inherited methods which we implemented
            file1.ReadFile();
            file1.WriteFile();
            file1.DisplayName();
            //file2.DisplayName(); //compile-time error 
        }
    }
}