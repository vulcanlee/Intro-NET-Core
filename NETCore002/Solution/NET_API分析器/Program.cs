using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NET_API分析器
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.WindowWidth = 120;
                Console.WindowHeight = 10;
            }
            Console.ForegroundColor = ConsoleColor.Red;

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
