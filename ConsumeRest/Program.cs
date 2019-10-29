using System;

namespace ConsumeRest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Worker worker = new Worker();

            worker.Start();

            Console.ReadLine();

        }
    }
}
