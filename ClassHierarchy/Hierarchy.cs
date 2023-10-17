namespace ClassHierarchy
{
    class Small
    {
        //base class or parent class
    }

    class Big :Small
    {
        //child class
        //more derived
    }

    class Bigger : Big
    {
        //child class
        //even more derived than Big
    }
    internal class Hierarchy
    {
        static void Main(string[] args)
        {
            Small small = new Small();
            Small small1 = new Big(); //the small can fit in a big class cause its nto so derived
            Small small2 = new Bigger();

            Big big = new Big();
            Big big1= new Bigger();
            Big big2 = new Small(); //the big (more derived) CANT fit into small, the less derived class

            Bigger bigger = new Bigger();
            Bigger bigger1 = new Small(); //the bigger (even more derived) CANT fit the less derived class
            Bigger bigger2 = new Big(); //the bigger (even more derived) CANT fit into the less derived class

            // ==> a base class can hold a derived class but a derived class cannot hold a base class. 
            //!!! (the parent can hold their child but the child cant hold the parent)
            //In other word, an instance can accept big even if it demands small, but it cannot accept small if it demands big.
        }
    }
}