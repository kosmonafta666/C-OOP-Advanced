namespace Collection_Hierarchy.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AddRemoveCollection : Collection, IAddable, IRemovable
    {
        public int Add(string element)
        {
            base.Elements.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            string element = base.Elements[Elements.Count - 1];
            base.Elements.RemoveAt(Elements.Count - 1);
            return element;
        }
    }
}
