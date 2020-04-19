using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public static class MyLinkedListExtension
    {
        public static MyLinkedList<int> AddWithSort (this MyLinkedList<int> myList, int data)
        {
            int count = 0;
            if (myList.GetHead() == null)
            {
                myList.AddHead(data);
                myList.IncreaseCount();
            }
            
             else
            {
                foreach (int num in myList) {
                    if (num <= data)
                        count++;
                }
                
            }
            if (myList.GetHead() == null || myList.Count==1) { }
            else {
                bool isSorted = myList.IsSorted();
                if (isSorted==false) {
                    throw new Exception("Список не отсортирован");
                }
            }
            //Console.WriteLine("count is " + count);
            myList.Insert(count+1, data);

            Console.WriteLine("------------");
            foreach (int num1 in myList)
            {
                Console.WriteLine(num1);
            }

            return myList;
        }
    }
}
