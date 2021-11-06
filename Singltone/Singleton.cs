using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance;
        private readonly int _instanceCount;
        private object obj = new object();
        private Singleton()
        {
            lock (obj)
            {
                _instanceCount++;
                Console.WriteLine($"Number Of Instances:{_instanceCount}");
            }
           
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
        public static Singleton GetInstance => _instance ?? new Singleton();
    }
}