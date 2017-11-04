using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Point myPoint = new Point();  // create new object
            myPoint.X = 10;
            myPoint.Y = 10;
            Console.WriteLine("myPoint.x = {0}", myPoint.X);
            Console.WriteLine("myPoint.y = {0}", myPoint.Y);
            Console.ReadLine();
        }
    }

    class Point          // class name
    {
        private int x;    // fields
        private int y;

        public int X      // properties
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
