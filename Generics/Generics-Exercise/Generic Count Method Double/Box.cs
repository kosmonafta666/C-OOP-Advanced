namespace Generic_Count_Method_Double
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Box<T> where T : IComparable<T>
    {
        private T value;

        public Box()
            : this(default(T))
        {

        }

        public Box(T value)
        {
            this.Value = value;
        }

        public T Value
        {
            get { return this.value; }

            set { this.value = value; }
        }
    }

}
