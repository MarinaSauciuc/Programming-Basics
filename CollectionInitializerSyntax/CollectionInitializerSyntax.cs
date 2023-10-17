namespace CollectionInitializerSyntax
{
    internal class CollectionInitializerSyntax
    {
        static void Main(string[] args)
        {
            var student1 = new Student() { Id = 1, Name = "Bill" };
            var student2 = new Student() { Id = 2, Name = "John" };
            var student3 = new Student() { Id = 3, Name = "Robert" };
            var student4 = new Student() { Id = 4, Name = "Tim" };

            IList<Student> studentList = new List<Student>() //fara ; aici
            {
                student1,
                student2,
                student3,
                student4
            };
            
            Console.WriteLine("Total Students: {0}", studentList.Count);

            //You can also initialize collections and objects at the same time.
            IList<Student> studentList2 = new List<Student>() {
                    new Student() { Id = 1, Name = "John"} ,
                    new Student() { Id = 2, Name = "Steve"} ,
                    new Student() { Id = 3, Name = "Bill"} ,
                    new Student() { Id = 3, Name = "Bill"} ,
                    new Student() { Id = 4, Name = "Ram" } ,
                    new Student() { Id = 5, Name = "Ron" }
            };

            Console.WriteLine("Total Students: {0}", studentList2.Count);




        }

    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}




