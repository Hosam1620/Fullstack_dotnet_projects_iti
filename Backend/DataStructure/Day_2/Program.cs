namespace Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region stack 
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Stack Top (Peek): " + stack.Peek()); 
            Console.WriteLine("Pop: " + stack.Pop());               
            Console.WriteLine("Pop: " + stack.Pop());               
            Console.WriteLine("IsEmpty: " + stack.IsEmpty());       
            Console.WriteLine("Pop: " + stack.Pop());               
            Console.WriteLine("IsEmpty: " + stack.IsEmpty());
            #endregion

            Console.WriteLine("----------------------------------------------");

            #region queue
            int[] initialData = { 1, 2, 3, 4, 5 };
            Queue queue = new Queue(initialData);

            Console.WriteLine("Peek (front): " + queue.Peek());     
            Console.WriteLine("Dequeue: " + queue.Dequeue());      
            Console.WriteLine("Dequeue: " + queue.Dequeue());       
            Console.WriteLine("IsEmpty: " + queue.IsEmpty());       
            queue.Enqueue(99);
            Console.WriteLine("Peek after Enqueue(9): " + queue.Peek()); 
            #endregion



        }
    }
}
