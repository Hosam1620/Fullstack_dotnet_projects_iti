using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1
{
    class MyLinkedList
    {
        private Node? head;
        private Node? tail;

        public MyLinkedList()
        {
            head = null;
            tail = null;
        }

        //add last
        public void InsertLast(Employee emp)
        {
            Node newNode = new Node(emp);

            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail!.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
        }
        // search
        public Node? Search(int id)
        {
            Node current = head!;

            while (current != null)
            {
                if (current.Data.ID == id)
                    return current;

                current = current.Next!;
            }

            return null;
        }
        //delete
        public void Delete(int id)
        {
            Node? node = Search(id);

            if (node == null)
            {
                Console.WriteLine("Employee not found");
                return;
            }

            if (node == head)
                head = node.Next;

            if (node == tail)
                tail = node.Prev;

            if (node.Next != null)
                node.Next.Prev = node.Prev;

            if (node.Prev != null)
                node.Prev.Next = node.Next;
        }


        //display
        public void Display()
        {
            Node? current = head;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }


    }
}

