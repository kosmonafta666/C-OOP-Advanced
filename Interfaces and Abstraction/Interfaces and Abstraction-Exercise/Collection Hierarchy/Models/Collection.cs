namespace Collection_Hierarchy.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public abstract class Collection
    {
        const int MAX_CAPACITY = 100;

        private List<string> elements;

        protected Collection()
        {
            this.elements = new List<string>(MAX_CAPACITY);
        }

        public List<string> Elements
        {
            get { return this.elements; }

            set { this.elements = value; }
        }
    }
}
