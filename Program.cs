﻿namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Stacks and Queues");
            Queue qu = new Queue();
            qu.Enqueue(56);
            qu.Enqueue(30);
            qu.Enqueue(70);
            Console.WriteLine("\n~~~~~~~~~stack elements~~~~~~~~~");
            qu.Display();
        }
    }
}