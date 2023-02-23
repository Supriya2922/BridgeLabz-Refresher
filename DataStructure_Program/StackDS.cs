using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Program
{
   
      
    public class StackDS<T>
    {
        Node<T> top;
        public StackDS()
        {
            this.top = null;
        }
        public void Push(T val)
        {
            Node<T> newNode = new Node<T>(val);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
           
        }
        public T Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Cannot delete due to Stack Underflow");
                return default(T);
            }
            T elem= top.val;
            top = top.next;
            return elem;
        }
        public Node<T> peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return null;
            }
            return this.top;
        }
        public void display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            else
            {
                Node<T> temp = top;
                while (temp != null)
                {
                    Console.Write(temp.val);
                    temp = temp.next;
                    if (temp != null)
                    {
                        Console.Write(" -> ");
                    }
                }
            }
        }
        public bool isEmpty()
        {
            if (top == null)
            {
                
                return true;
            }
            return false;
        }
        public bool validParenthesis()
        {
            StackDS<char> stack=new StackDS<char>();
            Console.WriteLine("Enter the expression");
            String exp=Console.ReadLine();
            char[] ch = exp.ToCharArray();
            String p = "";
            for(int i=0;i<ch.Length;i++)
            {
                if (ch[i]== '(' || ch[i] == '{' ||  ch[i] == '[' ) {
                    stack.Push(ch[i]);
                    continue;
                }
                if (stack.isEmpty())
                {
                    return false;
                }
                char popChar;
                switch (ch[i])
                {
                    case ')':
                        popChar = (char)stack.Pop();
                        if (popChar == '{' || popChar == '[')
                            return false;
                        break;
                    case '}':
                        popChar = (char)stack.Pop();
                        if (popChar == '(' || popChar == '[')
                            return false;
                        break;
                    case ']':
                        popChar = (char)stack.Pop();
                        if (popChar == '(' || popChar == '{')
                            return false;
                        break;
                }

            }
            return (stack.isEmpty());
            
        }
    }
}
