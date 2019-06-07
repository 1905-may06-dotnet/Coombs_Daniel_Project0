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
            DelShapes ds = new DelShapes(ShapeArea.CircleArea);
            //DelShape ds = ShapeArea.CircleArea also works
            ds += ShapeArea.SquareArea; //Invocation list - FIFO order

            //3. Invocation of delegates
            ds(2.5);
            
            //Predefined delegates in C#
            //1. Action - Delgate of type void
            //2. Func - Delegate of return type

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
    }
}
