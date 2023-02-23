using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructure_Program
{
   
    public class QueueDS
    {
        public class NodeQ
        {
            public int data;
            public NodeQ next;
            public NodeQ(int d)
            {
                data = d;
                next = null;
            }

        }
        public static int size = 0;
        public NodeQ front;
        public NodeQ rear;
        
        public QueueDS()
        {
            this.front = null;
            this.rear = null;
        }
        public void display()
        {
            NodeQ p = this.front;
            while (p != rear.next)
            {
           Console.WriteLine(p.data);
                p = p.next;

            }
        }
        public void Enqueue(int val)
        {
            NodeQ newNode = new NodeQ(val);
            if (rear == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
            size=size+1;
           
            
        }
        public int Dequeue()
        {
            if (this.front == null)
            {
                Console.WriteLine("The queue is empty");
                return 0;
            }
            NodeQ temp = this.front;
            this.front = this.front.next;
            if (this.front == null)
            {
                this.rear = null;
            }
            size--;
           
             return temp.data;
        }
      
        public int checkBalance()
        {
            int temp = 0;
            
            if (size == 0)
            {
                Console.WriteLine("Empty");
                return 0;
            }
            NodeQ p = this.front;
            while (p != rear.next)
            {
                temp = temp+p.data;
                p = p.next;

            }
            return temp;
        }
        public int sizeQ()
        {
            Console.WriteLine(size);
            return size;
        }
        public void displayBalance()
        {
            int temp = 0;
            Console.WriteLine("The availabale balance is");
            if (size == 0)
            {
                Console.WriteLine("Empty");
                return;
            }
            NodeQ p = this.front;
            while (p != rear.next)
            {
                temp = temp + p.data; 
                p=p.next;

            }
            Console.WriteLine(temp);
        }
    }
}
