using System;
using System.Collections.Generic;
using System.Linq;

namespace Socks
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Stack<int> leftSocks = new Stack<int>();
            Queue<int> rightSocks = new Queue<int>();
            var readLeftSocks = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var readRightSocks = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var listOfPair = new List<int>();
            int maxPair = 0;
            foreach (var sock in readLeftSocks)
            {
                leftSocks.Push(int.Parse(sock));
            }
            foreach (var sock in readRightSocks)
            {
                rightSocks.Enqueue(int.Parse(sock));
            }
            while (leftSocks.Count!=0&&rightSocks.Count!=0)
            {
                var currentLeftSock = leftSocks.Peek();
                var currerntRightSock = rightSocks.Peek();
                if (currentLeftSock > currerntRightSock)
                {
                    leftSocks.Pop();
                    rightSocks.Dequeue();
                    int max = currentLeftSock + currerntRightSock;
                    if (maxPair<max)
                    {
                        maxPair = max;
                    }
                    listOfPair.Add(max);
                }
                else if (currentLeftSock < currerntRightSock)
                {
                    leftSocks.Pop();
                }
                else if (currentLeftSock == currerntRightSock)
                {
                    rightSocks.Dequeue();
                    leftSocks.Push(leftSocks.Pop() + 1);
                }
            }
            Console.WriteLine(maxPair);
            Console.WriteLine(string.Join(" ",listOfPair));
        }
    }
}
