using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ConsoleApp5
{
    class MyLinkedList<T> : IEnumerable<T>
    {
        Node<T> head; 
        Node<T> tail; 
        int count;  

        // добвление в начало
        public void AddHead(T data) 
        {
            Node<T> node = new Node<T>(data);
            node.Next = head;
            head = node;
            if (count == 0)
                tail = head;
            count++;
        }

        // удаление элемента из начала
        public bool RemoveHead(T data)
        {
            head = head.Next;
            // если после удаления список пуст, сбрасываем tail
            if (head == null)
            tail = null;          
            return true; 
        }

        // получение значения элемента в начале списка
        public T GetHead()
        {
            return head.Data;
        }

        // получение значения элемента в начале списка
        public T GetTail()
        {
            return tail.Data;
        }

        // реализация интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        
    }
}
