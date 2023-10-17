using System.Text.RegularExpressions;

namespace CustomExceptions
{
    internal class CustomExceptions
    {
        static void Main(string[] args)
        {

            try
            {
                
                Student newStudent = new Student();
                newStudent.StudentName = Console.ReadLine();

                ValidateStudent(newStudent);

            }
            catch (InvalidStudentNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    

        private static void ValidateStudent(Student std)
        {
            Regex regex = new Regex("^[a-zA-Z]+$"); //regex makes you adhere to a certain format

            if (!regex.IsMatch(std.StudentName))
                throw new InvalidStudentNameException(std.StudentName);

        }
    }

    class Student //outside the Program class
    {
        public int StudentId { get; set; }
        public string StudentName { get; set;}
    }

    [Serializable]
    //making your own exception, your exception class MUST inherit system's Exception
    class InvalidStudentNameException : Exception 
    {
        public InvalidStudentNameException() { } //constructor
        public InvalidStudentNameException (string name) //connstructor
            : base(String.Format("Invalid Student Name : {0}", name))
        { }
    }





}