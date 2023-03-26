using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
namespace Stack1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Stack stack = new Stack();
            for(int i=0; i<arr.Length; i++) {
                stack.Push(arr[i]);
            }
            Console.WriteLine(stack);
            Console.WriteLine("Peek:"+stack.Peek()+"\n");
            for (int i = 0; i < arr.Length; i++) 
            { Console.WriteLine("pop :"+stack.Pop()); }
    }
    }
}

