using System;

namespace coolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There Again!");
            Stuff stuff = new();
            stuff.x = 3;
            stuff.y = 2;
            Console.WriteLine($"The sum is {stuff.sum()}");
        }
    }
}
