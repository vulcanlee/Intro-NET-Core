using System;
using System.Collections;

namespace NET_API分析器
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WindowWidth = 120;
            Console.WindowHeight = 10;
            Console.ForegroundColor = ConsoleColor.Red;

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
