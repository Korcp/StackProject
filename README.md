# StackProject


#스택배열 

<img width="400" alt="스택배열 결과" src="https://user-images.githubusercontent.com/48702154/227792483-badd8051-bcc8-484d-b45f-25c3dbccbc5a.png">

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
            int[] arr = { 1, 2, 3, 4, 5 }; //배열 생성
            Stack stack = new Stack();      // Stack객체 사용
            for (int i = 0; i < arr.Length; i++) //반복문을통해서 stack에 배열을 push하여넣음
            {
                stack.Push(arr[i]);
            }
            Console.WriteLine("Peek:"+stack.Peek()+"\n"); //스택의 꼭대기 출력
            for (int i = 0; i < arr.Length; i++) 
            { Console.WriteLine("pop :"+stack.Pop()); } //스택의 내용을 하나씩 삭제하면서 그 삭제되는 값을 
    }
    }
}



#링크드 리스트 배열

<img width="398" alt="링크드 리스트 스택" src="https://user-images.githubusercontent.com/48702154/227792435-1bee519c-af6f-4440-ac60-fc2d87042d39.png">

using System;
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

        class Node  //노드 생성
        {
            internal int data;
            internal Node next;
            public Node(int data)
            {
                this.data = data;
                next = null;
            }
        }
        class LinkedList //링크리스트 클래스 생성
        {
            private Node head;

            public void addHead(int data)  //노드의 head를만듬
            {
                Node newNode = new Node(data);
                newNode.next = head;
                head = newNode;
            }
            public int getHead()  //head의 데이터가 없으면 노드헤드의값이없고 헤드의 데이터를 반환함
            {
                if (head == null)
                    return -1;
                return head.data;
            }
            public void deleteHead() { //head 의 값을 삭제 : 헤드의위치를 헤드다음으로 이동함
                head = head.next;
            }
        }
          class Stack  //스택 클래스 생성
            {
                private LinkedList list = new LinkedList(); //링크드 리스트 객체 생성

                public void Push(int data) //  push 생성 링크드리스트의 시작에 데이터를 넣는다-> push 스택은 Firstin Last out이기때문
                {
                    list.addHead(data);
                }

            public int pop() //pop 생성
            {
                int temp = list.getHead();  //temp에 값을넣고 값을 삭제한후 temp를 반환해주면 pop구현가능
                list.deleteHead();
                return temp;
            }

            }
        

            static void Main(string[] args)
            {
            Stack stack = new Stack(); //스택 클래스 호출
            stack.Push(1);  //스택에 1이라는 값을  링크트리스트 머리에 넣음
            stack.Push(2); //스택에 1을 다음으로 보내고 2이라는 값을 링크트리스트머리에넣음
            stack.Push(3); //위와 동일
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine("pop :"+stack.pop()); // 스택 pop 구현 
            Console.WriteLine("pop :"+stack.pop());
            Console.WriteLine("pop :" + stack.pop());
            Console.WriteLine("pop :" + stack.pop());
            Console.WriteLine("pop :" + stack.pop());
        }
        }
    }

