using System;

namespace App.Logic
{
    public class LogicClass<T> : ILogic<T> //implement interface
    {
        int a;

        public int value { //interface
            get { return a; }
            set { a = value; }
        }

        public static string Reverse(string a)
        {
            string temp = "";
            foreach (var cr in a)
            {
                temp = cr + temp;
            }
            return temp;
        }

        /*public static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            (a, b) = (b, a); //tuple

        }*/

       /* public static void Swap(string a, string b)
        {
            string temp;
            temp = a;
            a = b;
            b = temp;
        }*/

        public static void Swap<T>(ref T a, ref T b) 
            //where T : struct 
            //where U: class //applying a constraint
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        public void Swap<T1>(T1 a, T1 b) //interface
        {
            (a,b) = (b,a);
        }
    }
}
