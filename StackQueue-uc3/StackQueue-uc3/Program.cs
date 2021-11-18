using System;
using System.Collections.Generic;

namespace StackQueue_uc3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("56");
            queue.Enqueue("30");
            queue.Enqueue("70");
            
            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
            queue.Dequeue();
            
        }
    }
}
