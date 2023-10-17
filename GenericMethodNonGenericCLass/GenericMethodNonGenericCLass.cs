namespace GenericMethodNonGenericCLass
{
    internal class GenericMethodNonGenericCLass
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print<int>(100);
            printer.Print(200);

            printer.Print<string>("hallo");
            printer.Print("hello");
        }

        class Printer //non generic class
        {
            public void Print<T>(T data) //generic method
            {
                Console.WriteLine(data);
            }
        }
    }
}