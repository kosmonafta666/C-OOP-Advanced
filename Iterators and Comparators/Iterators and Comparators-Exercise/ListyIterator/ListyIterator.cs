namespace ListyIterator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> data;
        private int indexPosition;

        public ListyIterator()
        {
            this.data = new List<T>();
        }

        public ListyIterator(IEnumerable<T> list)
        {
            this.data = new List<T>(list);
        }

        public bool Move()
        {
            if (this.indexPosition < this.data.Count - 1)
            {
                this.indexPosition++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasNext()
        {
            if (this.indexPosition < this.data.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (this.data.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(this.data[indexPosition]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
