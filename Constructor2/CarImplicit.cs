namespace ConstructorImplicit
{
    internal class CarImplicit
    {
        string name;
        int number;
       
        static void Main(string[] args)
        {
            CarImplicit car = new CarImplicit();
            car.name = "Volvo";
            car.number = 400;
            Console.WriteLine("The name of the car is {0} and the number is {1}", car.name, car.number);
        }
    }
}