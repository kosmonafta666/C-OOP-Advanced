namespace Custom_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IGenericList<T> : IEnumerable<T>
    {
        IList<T> Elements { get; }

        void Add(T element);

        T Remove(int index);

        bool Contains(T element);

        void Swap(int index1, int index2);

        int CountGreaterThan(T element);

        T Max();

        T Min();

    }
}
