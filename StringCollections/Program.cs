using System;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        public static void Main(string[] args)
        {
            //List T
            List<string> list = new List<string>();
            //Stack T
            Stack<string> stack = new Stack<string>();
            //Queue T
            Queue<string> queue = new Queue<string>();
            //HashSet T
            HashSet<string> hashSet = new HashSet<string>();

            //Insert five strings into each collection
            list.AddRange(new string[] { "A", "B", "C", "B", "E" });

            //Stacks following list pattern
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("B");
            stack.Push("D");

            //Queues following list pattern
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");
            queue.Enqueue("B");
            queue.Enqueue("D");

            //HashSets following list pattern
            hashSet.Add("A");
            hashSet.Add("B");
            hashSet.Add("C");
            hashSet.Add("B");
            hashSet.Add("D");
        }

        
    }
}
