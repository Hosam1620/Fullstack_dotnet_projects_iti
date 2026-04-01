using System;
using System.Collections.Generic;


public class Stack<T>
{
    private LinkedList<T> list = new LinkedList<T>();

    public void Push(T data)
    {
        list.AddFirst(data); // Add to front (top of stack)
    }

    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty.");

        T value = list.First!.Value;
        list.RemoveFirst();
        return value;
    }

    public bool IsEmpty()
    {
        return list.Count == 0;
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty.");
        return list.First!.Value;
    }
}