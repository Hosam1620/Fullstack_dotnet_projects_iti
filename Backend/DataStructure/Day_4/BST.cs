using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class BST
    {
        public Node? Root;

        public void Insert(int value)
        {
            Root = InsertRec(Root!, value);
        }

        private Node InsertRec(Node root, int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return root;
            }

            if (value < root.Data)
                root.Left = InsertRec(root.Left!, value);

            else if (value > root.Data)
                root.Right = InsertRec(root.Right!, value);

            return root;
        }

        // PreOrder
        public void PreOrder(Node root)
        {
            if (root != null)
            {
                Console.Write(root.Data + " ");
                PreOrder(root.Left!);
                PreOrder(root.Right!);
            }
        }

        // InOrder
        public void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.Left!);
                Console.Write(root.Data + " ");
                InOrder(root.Right!);
            }
        }

        // PostOrder
        public void PostOrder(Node root)
        {
            if (root != null)
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                Console.Write(root.Data + " ");
            }
        }
    }
}
