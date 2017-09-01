namespace Strategy_Pattern.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AgeComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
    }
}
