using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;

namespace CSVtest
{

    internal class Csv
    {
        static void Main(string[] args)
        {
            var myPersonObjects = new List<Person>() //object initialize syntax
            {
                new Person { Id = 1, IsLiving = true, Name = "John" },
                new Person { Id = 2, IsLiving = true, Name = "Steve" },
                new Person { Id = 3, IsLiving = true, Name = "James" },
            };


            //Person pulamea = new Person { Id = 1, IsLiving = true, Name = "John" };
            //myPersonObjects.Add(pulamea);

            var configPersons = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false
            };
            using (var stream = File.Open("filePersons.csv", FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, configPersons))
            {
                csv.WriteRecords(myPersonObjects);
            }
        }
    }

    public class Person
    {

        public int Id { get; set; }

        public bool IsLiving { get; set; }

        public string Name { get; set; }


    }



}