namespace Tuples
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tuple<T, U, V>
    {
        private T item1;
        private U item2;
        private V item3;

        public Tuple(T item1, U item2, V item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public override string ToString()
        {
            return $"{this.item1} -> {this.item2} -> {this.item3}";
        }
    }
}
