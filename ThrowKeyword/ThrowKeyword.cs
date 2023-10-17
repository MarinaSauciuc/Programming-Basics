namespace ThrowKeyword

//An exception can be raised manually by using the throw keyword.
//Any type of exceptions which is derived from Exception class can be raised using the throw keyword.
{
    internal class ThrowKeyword
    {
        static void Main(string[] args)
        {
            Student student = null;

            try
            {
                PrintStudentName(student);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        public class Student
        {
            public string StudentName { get; set; }
        }

        public static void PrintStudentName (Student student)
        {
            if (student == null)
            {
                throw new NullReferenceException("Student object is null");
                //Please notice that throw creates an object of any valid exception type using the new keyword.
                //The throw keyword cannot be used with any other type which does not derive from the Exception class.
            }
            Console.WriteLine(student.StudentName);
        }
    }
}