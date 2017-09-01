namespace Custom_List.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Sorted
    {
        public static IGenericList<T> Sort<T>(IGenericList<T> customList)
            where T : IComparable<T> 
        {
            var result = customList.Elements.OrderBy(x => x);

            return new GenericList<T>(result);
        }
    }
}
