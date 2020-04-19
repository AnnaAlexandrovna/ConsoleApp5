using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> myListOfInt = new MyLinkedList<int>();

            myListOfInt.AddHead(7);
            myListOfInt.AddHead(5);
            myListOfInt.AddHead(4);
            myListOfInt.AddHead(3);
            myListOfInt.AddHead(22);
            myListOfInt.AddHead(1);
            foreach (int num in myListOfInt) {
                Console.WriteLine(num);
            }

            try
            {
                myListOfInt.AddWithSort(8);
            }
            catch (Exception e) {
                Console.WriteLine($"Ошибка: {e.Message}");
            }

            Console.WriteLine("-------------");
            MyLinkedList<string> myListOfString = new MyLinkedList<string>();
            myListOfString.AddHead("d");
            myListOfString.AddHead("c");
            myListOfString.AddHead("b");
            myListOfString.AddHead("a");
            foreach (string str in myListOfString)
            {
                Console.WriteLine(str);
            }
        }
    }
}
