using System;

namespace HackerRankTest.Tests
{
    public class OwnLinkedList 
    { 
        public OwnLinkedList Next { get; set; }

        public int Data { get; set; }
        public OwnLinkedList(int data)
        {
            Data = data;
        }

        public void AppendToTail(int data) 
        {
            OwnLinkedList node_end = new OwnLinkedList(data);
            OwnLinkedList current = this;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = node_end;
        }

        public void Print() 
        {
            OwnLinkedList first = this;

            while (first.Next != null) 
            {
                Console.WriteLine($"Value: {first.Data}");
                first = first.Next;
            }
            Console.WriteLine($"Value: {first.Data}");
        }

    }


    public static class DataTypeLinkedList
    {

        public static void Execute() 
        {
            OwnLinkedList ownerList = new OwnLinkedList(1);
            ownerList.AppendToTail(2);
            ownerList.AppendToTail(3);

            ownerList.Print();
        }
        


    }
}
