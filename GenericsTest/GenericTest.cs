using System.Reflection.Metadata;

namespace GenericsTest
{
    internal class GenericTest
    {
        static void Main(string[] args)
        {
            DataStore<string> cities = new DataStore<string>(); //instantiating a generic class
            //You can create an instance of generic classes by specifying an actual type in angle brackets. 
            //T will be replaced with a string type wherever T is used in the entire class at compile-time.
            cities.AddOrUpdate(0, "Barlad");
            cities.AddOrUpdate(1, "Iasi");
            cities.AddOrUpdate(2, "Vaslui");
            cities.AddOrUpdate(3, "Barlad");
            cities.AddOrUpdate(4, "Iasi");
            cities.AddOrUpdate(5, "Vaslui");
            cities.AddOrUpdate(6, "Barlad");
            cities.AddOrUpdate(7, "Iasi");
            cities.AddOrUpdate(8, "Vaslui");

            Console.WriteLine(cities.GetData(2));
            Console.WriteLine(cities.GetData(9));

            DataStore<int> empIds = new DataStore<int>();
            //You can specify the different data types for different objects.
            //The above example uses STRING, this example uses INT
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);
            empIds.AddOrUpdate(3, 100);
            empIds.AddOrUpdate(4, 165);
            empIds.AddOrUpdate(5, 211);
            empIds.AddOrUpdate(6, 256);
            empIds.AddOrUpdate(7, 300);
            empIds.AddOrUpdate(8, 306);

            Console.WriteLine(empIds.GetData(2));
            Console.WriteLine(empIds.GetData(9));

        }

        class DataStore<T> //generic class
         //Generic classes are defined using a TYPE PARAMETER in an angle brackets after the class name.
         //T is called type parameter
        {
            private T[] _data = new T[10]; //generic array without declaring what TYPE PARAMETER T would be

            public void AddOrUpdate(int index, T item) //generic method
         //data type of the item parameter will be specified at the time of instantiating the DataStore<T> class --> see main method
            {
                if (index >= 0 && index <5)
                {
                    _data[index] = item;
                }
                
            }

            public T GetData(int index) //generic method because generic return
            {
                if (index >= 0 && index <5)
                {
                    return _data[index];
                }

                else
                    return default(T);
            }

        }



    }
}