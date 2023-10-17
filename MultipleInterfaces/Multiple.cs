namespace MultipleInterfaces
{
    interface IFile
    {
        void ReadFile(); //same named method but different interface
    }

    interface IBinaryFile
    {
        void OpenBinaryFile();
        void ReadFile(); //same named method but different interface
    }

    class FileInfo :IFile, IBinaryFile //a class can inherit multiple interfaces
    {
        //we need explicit implementation because we work with multple interfaces and same name method inside of them
        void IFile.ReadFile() //explicit implementation for ReadFile() method in iFile
        {
            Console.WriteLine("Reading text file");
        }

        void IBinaryFile.ReadFile() //explicit implementation for ReadFile() method in iBinaryFile
                                    // iBinaryFile has ReadFile() that has the SAME NAME as the method in iFile
        {
            Console.WriteLine("Reading binary file");

        }
        void IBinaryFile.OpenBinaryFile() ////explicit implementation for OpenBianryFile() method in iBinaryFile
        {
            Console.WriteLine("Opening binary file");
        }

        public void Search() //stand alone method of the FileInfo class
        {
            Console.WriteLine("Searching file");
        }

    }


    internal class Multiple
    {
        static void Main(string[] args)
        {
            //creating objects

            IFile file1 = new FileInfo(); //assign iFile to FileInfo obj
            IBinaryFile file2 = new FileInfo(); //assign iBinaryFile to FileInfo obj
            FileInfo file3 = new FileInfo(); //creating FileInfo obj

            //IFile file1 can ONLY access iFile interface members
            file1.ReadFile();
            //file1.OpenBinaryFile(); compile error
            //file1.Search();  compile error

            //IBinaryFile file2 can ONLY access iBinaryFile interface members
            file2.ReadFile();
            file2.OpenBinaryFile();
            //file2.Seach();  compile error

            //FileInfo file3 can ONLY access FileInfo class members that cant be found in the interfaces
            //file3.ReadFile();  compile error
            //file3.OpenBinaryFile();  compile error
            file3.Search(); 


        }
    }
}