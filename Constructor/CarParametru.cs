namespace ConstructorCuParametru
{
    internal class CarParametru
    {
        string name;
        int number;

        CarParametru(string name, int number) //the constructor is written inside the class, it has the same name as the class
        {
            this.name = name;
            this.number = number;
        }

        //or it can be written like this, however the above version is easier
        //Car(string theName, int theNumber) //the constructor
        //{
        //    name = theName;
        //    number = theNumber;
        //}
        static void Main(string[] args)
        {
            CarParametru car = new CarParametru("Volvo", 400);
            Console.WriteLine("The name of the car is {0} and the number is {1}", car.name, car.number);
        }

        //public void CheckCar(string name)
        //{
        //    if (this.name != name) { }

        //}
    }
}