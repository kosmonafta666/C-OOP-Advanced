namespace Strategy_Pattern.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            var result = x.Name.Length - y.Name.Length;

            if (result == 0)
            {
                char first = char.ToLower(x.Name[0]);

                char second = char.ToLower(y.Name[0]);

                result = first.CompareTo(second);
            }

            return result;
        }
    }
}
