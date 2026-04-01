namespace Day_4
{
    public class Program
    {
        static void Main()
        {
            BST tree = new BST();

            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine()!);
                tree.Insert(num);
            }

            Console.WriteLine("\nPreOrder Traversal:");
            tree.PreOrder(tree.Root!);

            Console.WriteLine("\nInOrder Traversal:");
            tree.InOrder(tree.Root!);

            Console.WriteLine("\nPostOrder Traversal:");
            tree.PostOrder(tree.Root!);
        }
    }
}
