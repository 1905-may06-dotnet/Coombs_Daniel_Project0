using System;

namespace DelegatesDemo
{
    //Delegate is a type safe fuction pointer
    //1. Declare a delegate
    delegate void DelShapes(double x);

    class Program
    {
        static void Main(string[] args)
        {
            //2. Instantiate a delegate
            //DelShapes ds = new DelShapes(ShapeArea.CircleArea);
            //DelShape ds = ShapeArea.CircleArea also works
            //ds += ShapeArea.SquareArea; //Invocation list - FIFO order

            //3. Invocation of delegates
            //ds(2.5);

            //Predefined delegates in C#
            //1. Action - Delgate of type void
            //Action<double> delAct = ShapeArea.CircleArea;

            //delegate is tied to an anonymous method
            Action<double> delAct;
            /*Action<double> delAct = delegate (double r) //anonymous method
            {
                double area = Math.PI * r * r;
                Console.WriteLine($"Area: {area}");
            };*/


            //delAct += ShapeArea.SquareArea;
            /*delAct += delegate (double s) //anonymous method
            {
                Console.WriteLine($"Area: {s*s}");
            };*/
            delAct = (r) => Console.WriteLine(Math.PI * r *r );

            delAct(6);
            //2. Func - Delegate of return type
            Func<double, double, double> DelFunc = ShapeArea.RectArea;
            Console.WriteLine($"Area of rectangle is {DelFunc(4, 8)}");

            //3. Predicate - bool

            //Anonymous methods - methods without names b/c 

        }

    }

    class ShapeArea
    {
        public static void CircleArea(double radius)
        {
            Console.WriteLine($"Area of circle with radius {radius} is {radius * radius * Math.PI}");
        }

        public static void SquareArea(double s)
        {
            Console.WriteLine($"Area of square with side {s} cm is {s * s}");
        }
        public static double RectArea(double w, double l)
        {
            return w * l;
        }
    }
}
