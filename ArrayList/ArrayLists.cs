using System.Collections;

namespace ArrayLists
{
    //ArrayList is included in System.Collections, its a NON-GENERIC collection
    //the generics are inside System.Collections.Generic
    //Create an object of the ArrayList using the new keyword.
    internal class ArrayLists
    {
        static void Main(string[] args)
        {
            //1. CREATE an ArrayList

            ArrayList arlist1 = new ArrayList();
            // or
            // var arlist = new ArrayLIst(); --> recommended
            arlist1.Add(1);
            arlist1.Add("Bob");
            arlist1.Add(true);
            arlist1.Add(null);
            arlist1.Add(4.5);

            var arlist2 = new ArrayList() //dont use ; here
            {
                2,"Steve", 10.3
            };// ; at this point

            int[] arlist3 = { 100, 200, 300, 400 };//this is an ARRAY

            var arlist4 = new ArrayList(); //just an emptyArrayLIst

            arlist4.AddRange(arlist1); //adding arraylist in arraylist 
            arlist4.AddRange(arlist2); ////adding array in arraylist

            //2. ACCESS individual item using indexer
            
            int firstElement = (int)arlist1[0]; //explicit casting
            //or
            var secondElement = arlist1[1]; // no need to use explicit casting if we use var


            //3. ITERATING through the arraylist
           
            foreach (var ar in arlist1)
            {
                Console.WriteLine(ar);
            }

            Console.WriteLine();//just to create a new empty line

            foreach (var item in arlist4)
            {
                Console.WriteLine($"This is arlist4 made from arraylist and array: {item}");
            }

            //4. UPDATE elements nad INSERT
            arlist1[1] = "Fran"; //update
            arlist1.Insert(0, "Maya"); //insert
            //InsertRange() method to insert a collection in an ArrayList at the specfied index.
            arlist1.InsertRange(6, arlist2); //the initial arraylist ended at 5 but we inserted "Maya"

            //other methods are Remove(), Contains() etc.

            Console.WriteLine("\nThe new arlist1 is:");

            foreach (var ar in arlist1)
            {    
                Console.WriteLine(ar);
            }

            // !!!! It is not recommended to use the ArrayList class due to performance issue.
            // Instead, use List<object> to store heterogeneous objects. To store data of same data type, use Generic List<T>.
        }
    }
}