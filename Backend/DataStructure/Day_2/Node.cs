using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    internal class Node
    {
        int data { get; set; }
        Node? next {  get; set; }
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
}
