using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Main started*****");
            MethodCall();
            Console.WriteLine("*****Main finished*****");
            Console.Read(); //allows method 1 and 2 to finish if not completed
        }
        static async void MethodCall()
        {
            Console.WriteLine("-----Inside Method 1-----");
            await Task.Run(new Action(LongMethod));
            Console.WriteLine("-----Method 1 finished executing-----");
        }

        private static void LongMethod()
        {
            Console.WriteLine("-----Method 2 started-----");
            Thread.Sleep(5000);
            Console.WriteLine("-----Method 2 finished-----");
        }
    }
}
