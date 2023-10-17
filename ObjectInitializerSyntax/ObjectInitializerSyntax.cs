namespace ObjectInitializerSyntax
//Object Initializer Syntax, a new way to initialize an object of a class or collection.
//Object initializers allow you to assign values to the fields or properties at the time of creating an object without invoking a constructor.
{
    internal class ObjectInitializerSyntax
    {
        static void Main(string[] args)
        {
            var student = new Student() //fara ; aici
            {
                Id = 1,
                Name = "John",
                Age = 25,
                Address = "Bucharest"
            };
            //In the Main() method, we have created Student object and assigned values to all or some properties in the curly bracket at the same time.
            //This is called object initializer syntax.

            Console.WriteLine($"The student name is {student.Name}, their age is {student.Age} and they live is {student.Address}");

        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}