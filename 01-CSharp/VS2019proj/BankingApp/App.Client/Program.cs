using System;
using App.Logic;

namespace App.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //string reverseStr = LogicClass.Reverse("Reverse");
            //Console.WriteLine(reverseStr);

            //Calling Swap - call by value (calling literal value)
            /*int x = 10, y = 20;
            Console.WriteLine($"Before Swapping, x={x} and y={y}");
            LogicClass.Swap(ref x, ref y);
            Console.WriteLine($"After Swapping, x={x} and y={y}");*/

            //multi values fields - can hold up to 8 items
            /*Tuple<int, int, string> tpl = new Tuple<int, int, string>(1, 2, "test"); //tuple example
            var item1 = tpl.Item1;
            Console.WriteLine(item1);*/

            var x = "Hello";
            var y = "World";
            LogicClass<string>.Swap<string>(ref x, ref y);
            var a = 27;
            var b = 13;
            LogicClass<int>.Swap<int>(ref a, ref b);
            Console.WriteLine($"x:{x},y:{y}");
            Console.WriteLine($"a:{a},b:{b}");
        }
       
    }
}
