using System;

public class Scale<T> where T : IComparable<T>
{
    private T left { get; set; }
    private T right { get; set; }

    public Scale(T left, T right)
    {
        this.left = left;
        this.right = right;
    }

    public T GetHavier()
    {
        if (this.left.CompareTo(this.right) > 0)
        {
            return this.left;
        }
        else if (this.left.CompareTo(right) < 0)
        {
            return this.right;
        }

        return default(T);
    }
}

