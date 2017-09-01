namespace Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Stack<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 10;

        private T[] elements;

        public int Count { get; set; }

        public int Capacity
        {
            get { return this.elements.Length; }
        }

        public Stack()
        {
            this.elements = new T[InitialCapacity];
        }

        public void Push(T element)
        {
            if (this.Count == this.Capacity)
            {
                this.Resize();
            }

            this.elements[this.Count] = element;

            this.Count++;
        }
        
        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            T result = this.elements[this.Count - 1];

            this.Count--;

            return result;
        }

        private void Resize()
        {
            this.elements = this.elements
                .Concat(new T[this.Count])
                .ToArray();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
