﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArrayEx1
{
    internal class Program
    {

        class Node
        {
            internal int data;
            internal Node next;
            public Node(int data)
            {
                this.data = data;
                next = null;
            }
        }
        class LinkedList
        {
            private Node head;

            public void addHead(int data)
            {
                Node newNode = new Node(data);
                newNode.next = head;
                head = newNode;
            }
            public int getHead()
            {
                if (head == null)
                    return -1;
                return head.data;
            }
            public void deleteHead() {
                head = head.next;
            }
        }
          class Stack
            {
                private LinkedList list = new LinkedList();

                public void Push(int data)
                {
                    list.addHead(data);
                }

            public int pop()
            {
                int temp = list.getHead();
                list.deleteHead();
                return temp;
            }

            }
        

            static void Main(string[] args)
            {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine("pop :"+stack.pop());
            Console.WriteLine("pop :"+stack.pop());
            Console.WriteLine("pop :" + stack.pop());
            Console.WriteLine("pop :" + stack.pop());
            Console.WriteLine("pop :" + stack.pop());
        }
        }
    }

