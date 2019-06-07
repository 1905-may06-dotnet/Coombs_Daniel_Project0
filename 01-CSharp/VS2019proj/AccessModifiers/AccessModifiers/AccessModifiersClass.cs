using System;
using System.Collections;

namespace AccessModifiers
{
    class AccessModifier
    {

        //readonly
        readonly int money = 5;
        void ChangeMoney()
        {
        //    money = 7;
        }

        public string color = "blue";
        public readonly string obj = "ball";
        public readonly string place;

        public AccessModifier()
        {
            place = "outside";
        }

        public AccessModifier(string color, string obj, string place)
        {
            this.color = color;
            this.obj = obj;
            this.place = place;
        }

        public static void Main()
        {
            /*AccessModifier a = new AccessModifier("red", "car", "road");

            //readonly
            //a.ChangeMoney();
            Console.WriteLine($"Color: {a.color}, Object: {a.obj}, Place: {a.place}");
            a.color = "blue";
            //a.obj = "computer"; would give a compile error
            Console.WriteLine($"Color: {a.color}, Object: {a.obj}, Place: {a.place}");*/




            var a = new ArrayList();
            a.Add("Sam");
            a.Add("Tom");
            a.Add("Carl");
            a.Add("Tom");

            a.Remove("Tom");

            foreach (var b in a)
            {
                Console.WriteLine(b);
            }
        }
    }
}