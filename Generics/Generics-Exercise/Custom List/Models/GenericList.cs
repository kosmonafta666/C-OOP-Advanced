using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    public class GenericList<T> : IGenericList<T>, IEnumerable<T> where T : IComparable<T>
    {
        private IList<T> elements;
       
        public IList<T> Elements
        {
            get { return this.elements; }
            private set { this.elements = value; }
        }

        public GenericList()
            :this(Enumerable.Empty<T>())
        {
        }

        public GenericList(IEnumerable<T> collection)
        {
            this.elements = new List<T>(collection);
        }

        public void Add(T element)
        {
            this.elements.Add(element);
        }

        public bool Contains(T element)
        {
            return this.elements.Contains(element);
        }

        public int CountGreaterThan(T element)
        {
            var count = 0;

            foreach (var item in elements)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public T Max()
        {
            return this.elements.Max();
        }

        public T Min()
        {
            return this.elements.Min();
        }

        public T Remove(int index)
        {
            T result = this.elements[index];

            this.elements.RemoveAt(index);

            return result;
        }

        public void Swap(int index1, int index2)
        {
            T temp = this.elements[index1];

            this.elements[index1] = this.elements[index2];

            this.elements[index2] = temp;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, this.elements);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.Elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
