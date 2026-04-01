using System;


public class Queue
{
    private int[] data;
    private int front = 0;
    private int back = 0;
    private int count = 0;

    public Queue(int[] initialData)
    {
        data = new int[initialData.Length];
        foreach (var item in initialData)
            Enqueue(item);
    }

    public void Enqueue(int value)
    {
        if (count == data.Length)
            throw new InvalidOperationException("Queue is full.");

        data[back % data.Length] = value;
        back++;
        count++;
    }

    public int Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue is empty.");

        int value = data[front % data.Length];
        front++;
        count--;
        return value;
    }

    public int Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue is empty.");
        return data[front % data.Length];
    }

    public bool IsEmpty()
    {
        return count == 0;
    }
}

