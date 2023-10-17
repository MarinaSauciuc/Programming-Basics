using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace StreamUse
{
    internal class StreamUse
    {
        //C# includes static File class to perform I/O (input/output) operation on physical file system.
        //The static File class includes various utility method to interact with physical file of any type e.g. binary, text etc.
        static void Main(string[] args)
        {
            //Check whether file is exists or not at particular location
            bool ifFileExists = File.Exists(@"E:\MA STUFF\Programming\StreamFile.txt");
            Console.WriteLine(ifFileExists);

            //Get when the file was accessed last time 
            DateTime lastAccessTime = File.GetLastAccessTime(@"E:\MA STUFF\Programming\StreamFile.txt");
            Console.WriteLine(lastAccessTime.ToString());

            //Use AppendAllLines() method to append multiple text lines to the specified file as shown below.
            //Every time the program runs, it adds the lines
            //string dummyLines = "This is first line." + Environment.NewLine +
            //        "This is second line." + Environment.NewLine +
            //        "This is third line.";
            //File.AppendAllLines(@"E:\MA STUFF\Programming\StreamFile.txt", dummyLines.Split(Environment.NewLine.ToCharArray()).ToList<string>());

            //Opens DummyFile.txt and append Text. If file is not exists then create and open.
            //Use File.WriteAllText() method instead to write texts to the file. Please note that it will not append text but overwrite existing texts.
            File.AppendAllText(@"E:\MA STUFF\Programming\StreamFile.txt", "This is file testing");

            //StreamReader and StreamWriter are built around reading text, so they handle the encoding for us. One is for reading, and the other is for writing.
            //Open file and return StreamReader for reading string from the file
            StreamReader sr = File.OpenText(@"E:\MA STUFF\Programming\StreamFile.txt");
            Console.WriteLine(sr.ReadToEnd());

        }
    }
}