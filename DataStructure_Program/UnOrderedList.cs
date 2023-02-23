using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace DataStructure_Program
{
    public class Node<T> 
    {
        public T val;
        public Node<T> next;
        public Node()
        {
            this.val = default(T);
            this.next = null;
        }
        public Node(T val)
        {
            this.val = val;
            this.next = null;
        }

    }
    public class UnOrderedList<T> 
    {
       
       
        Node<T> head;
        int size = 0;
        public UnOrderedList()
        {
            this.head = null;
        }
     
        public void add(T val)
        {
            Node<T> new_node = new Node<T>(val);
            if (this.head == null)
            {
                this.head = new_node;
                return;
            }
           

            Node<T> lastNode = GetLastNode();
            lastNode.next = new_node;

        }
        public Node<T> GetLastNode()
        {
            Node<T> temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
      
      
        public bool Search(T value) 
        {
           Node<T> curr = this.head;
            
            while (curr != null)
            {
                T data=curr.val;
                if (data.Equals(value))
                {
                    
                    return true;
                }
                curr = curr.next;
            }
            return false;

            
        }
        public void remove(T data)
        {
            Node<T> prev = new Node<T>();
            prev.next = this.head;
            Node<T> next = head.next;
            Node<T> temp = head;
            if((head.val).Equals(data))
            {
                head = head.next;
            }
            while(temp.next!=null)
            {
                if ((temp.val).Equals(data))
                {
                    prev.next = next;
                    break;
                }
            }
            prev = temp;
            temp = temp.next;
            next = temp.next;
        }
        public String listToString()
        {
            String str = "";
            Node<T> temp = head;
            while(temp.next != null)
            {
                 String s = String.Format("{0} ", temp.val);
                 str += s;
                
                temp = temp.next;
            }
            String s1 = String.Format("{0} ", temp.val);
            str += s1 + " ";
            return str;
        }

    }
}
