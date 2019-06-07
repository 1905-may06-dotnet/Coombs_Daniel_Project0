using System;
using Arithmatic;

namespace MainPlace
{
    static class ExtendingMathLogic
    {
        public static double CircleArea(this MathLogic m, double radius)
        {
            return radius * radius * Math.PI;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathLogic m = new MathLogic();
            m.Add(45, 65);
            m.CircleArea(5.5);
        }
        
    }
}
