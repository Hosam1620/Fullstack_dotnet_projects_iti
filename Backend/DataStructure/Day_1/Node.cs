using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1
{
    class Node
    {
        public Employee Data;
        public Node? Next;
        public Node? Prev;

        public Node(Employee data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }
}
