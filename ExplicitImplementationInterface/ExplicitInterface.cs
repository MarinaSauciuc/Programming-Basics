namespace ExplicitImplementationInterface
{
    interface IFile
    {
        void ReadFile();
        void WriteFile();

    }

    class FileInfo : IFile
    {
         void IFile.ReadFile() //explicit implementation
                               //we dont need public accessor
        {
            Console.WriteLine("Reading File");
        }

         void IFile.WriteFile()
        {
            Console.WriteLine("Writing File");
        }

        public void SearchFile() //this method isnt in the inherited interface
        {
            Console.WriteLine("Searching file");
        }


    }


    internal class ExplicitInterface
    {
        static void Main(string[] args)
        {
            //creating objects

            IFile file1 = new FileInfo();
            FileInfo file2 = new FileInfo();

            //!! IFile file1 object can only access existing members of IFile even tho we assigned iFile to FileInfo
            file1.ReadFile();
            file1.WriteFile();
            //file1.SearchFile(); gives compile error

            //!! FileInfo file2 can only access members of FileInfo class that arent in the interface. 
            file2.SearchFile();
            //file2.ReadFile(); gives compile error
            //file2.WriteFile(); gives compile error
            

            //the errors are LIMITATIONS OF EXPLICIT IMPLEMENTATION
            //Explicit implementation is useful when class is implementing multiple interfaces;
            //Also useful if interfaces have the same method name coincidently.



        }
    }
}