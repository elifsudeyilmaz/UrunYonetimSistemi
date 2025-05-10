using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunEnvanterApp
{
    public class Stack<T>
    {
        private class Node
        {
            public T Data;
            public Node Next;

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node top;
        private int size;

        public Stack()
        {
            top = null;
            size = 0;
        }

        // Eleman ekleme (push)
        public void Push(T item)
        {
            Node newNode = new Node(item);
            newNode.Next = top;
            top = newNode;
            size++;
        }

        // Eleman çıkarma (pop)
        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty!");

            T item = top.Data;
            top = top.Next;
            size--;
            return item;
        }

       
        

       
        public bool IsEmpty()
        {
            return size == 0;
        }

        
    }
}

