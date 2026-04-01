using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Node
    {
        public int Data;
        public Node? Left;
        public Node? Right;

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
