using System;

public class Box<T>
{
    private T data;

    public T Data
    {
        get { return this.data; }
        private set { this.data = value; }
    }

    public Box(T element)
    {
        this.Data = element;
    }

    public override string ToString()
    {
        return $"{this.Data.GetType().FullName}: {this.Data}";
    }
}

