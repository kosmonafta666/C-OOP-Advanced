namespace Arrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Arrays
    {
        public static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] integers = ArrayCreator.Create(10, 33);
            
            foreach (var item in integers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
