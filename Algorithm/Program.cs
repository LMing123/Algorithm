using Algorithm.Code;
using Algorithm.Code.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using Algorithm.Code.LeetCode.simple;
namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution_81.ListNode head = new Solution_81.ListNode(1);

            try
            {
                int input = int.Parse(Console.ReadLine());
                var q = head;
                while (true)
                {
                    q.next = new Solution_81.ListNode(input);
                    q = q.next;
                    Console.BackgroundColor=ConsoleColor.Cyan;
                    input = int.Parse(Console.ReadLine());
                    Console.ResetColor();
                }
            }catch
            {
                Console.WriteLine("fuck");
            }
            

            var shit = Solution_81.Fuck(head);
            Console.WriteLine(shit);

            Console.ReadLine();


        }
    }
}
