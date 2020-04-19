using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ConsoleApp5
{
    public class MyLinkedList<T> : IEnumerable<T>
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
            count--;
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

       // public T GetNextElement() {
        //    return 
       // }

        //количество элементов в списке
        public int Count { get { return count; } }

        //увеличение счетчика
        public void IncreaseCount() { count++; }

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

         LinkedList<int> l = new LinkedList<int>();
        

        public void Insert(int position, T data) {
            
            Node<T> current = head;
            Node<T> nextNode = head.Next;
            Node<T> testNode;

            if (position != 1)
            {
                for (int i = 0; i < position - 2; i++)
                {
                    //current = current.Next;
                    if (current.Next != null)
                    {
                        current = current.Next;
                        nextNode = current.Next;
                    }
                }
                Node<T> newElement = new Node<T>(data);
                testNode = current;
                current.Next = newElement;
                newElement.Next = nextNode;
                count++;
            }
            else {
                AddHead(data);
            }
            
        }


        public bool IsSorted() {

            Node<T> current = head;
            Node<T> nextNode = head.Next;
            while (current != tail) {
                try {
                    if (Convert.ToInt32(current.Data.ToString()) > Convert.ToInt32(current.Next.Data.ToString()))
                    {
                        return false;
                    }
                    current = current.Next;
                    nextNode = current.Next;
                }
                catch (Exception e) { Console.WriteLine($"Ошибка: {e.Message}"); }
            }
            return true;
        }
            

        }

        
    }

