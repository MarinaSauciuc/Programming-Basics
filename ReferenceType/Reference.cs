namespace ReferenceType
{
    public class Student
    {
        public string StudentName { get; set; }
    }
    internal class Reference
    {
        static void Main(string[] args) //main method
        {
            Student std1 = new Student();//instantiating class Student
            std1.StudentName = "Bill";
            Console.WriteLine(std1.StudentName);
            
            ChangeReferenceType(std1); //passing the reference to the other method
            
            Console.WriteLine(std1.StudentName);


        }
        
        public static void ChangeReferenceType(Student std2)//second method
        {
            std2.StudentName = "Steve";
            Console.WriteLine(std2.StudentName);
        }

        //!! When you pass a reference type variable from one method to another, it doesn't create a new copy;
        //instead, it passes the variable's address.
        //So, If we change the value of a variable in a method, it will also be reflected in the calling method.

        //Also note that in ABOVE EXAMPLE, we pass an object, not a string, the STRING is more SPECIAL

                    //The followings are reference type data types:
                            //String
                            //Arrays(even if their elements are value types)
                            //Class
                            //Delegate

        //basically, we pass Student OBJECT std1 instead of std2 as parameter in ChangeReferenceType, the calling method shows the new declaration with "Steve"
        //but when we go back recalling the method with the initial std1 parameter, the name remains "Steve"
        //Thus, when the ChangeReferenceType() method changes StudentName, it is actually changing StudentName of std1 object, because std1 and std2 are both pointing to the same address in memory.
        //the reference type is active even OUTSIDE of its own method


    }
}