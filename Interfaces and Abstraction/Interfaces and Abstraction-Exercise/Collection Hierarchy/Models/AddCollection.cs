namespace Collection_Hierarchy.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AddCollection : Collection, IAddable
    {
        public int Add(string element)
        {
            base.Elements.Add(element);
            return Elements.Count - 1;
        }
    }
}
