using System.Linq;
using System.Collections.Generic;

namespace ListsWithLINQ
{
    public class LINQListsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class LINQLists
    {
        static void Main(string[] args)
        {
            var students = new List<LINQListsDTO>()
            {
                new LINQListsDTO() { Id = 1, Name="Bob"},
                new LINQListsDTO() { Id = 2, Name="Harvey"},
                new LINQListsDTO() { Id = 3, Name="Steve"},
                new LINQListsDTO() { Id = 4, Name="John"},
                new LINQListsDTO() { Id = 5, Name="Bob"},
            }; //dont forget ;

            //get all students whose name is Bob using LINQ
            var studentName = from s in students    //de unde
                              where s.Name == "Bob" //unde -> filtrul
                              select s;             //selecteaza

            var sName = students.Where(s => s.Name == "John").ToList(); //with lambda

            foreach(var student in studentName)
            {
                Console.WriteLine(student.Id + ", " + student.Name);
            }

            


        }
    }
}