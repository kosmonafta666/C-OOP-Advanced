namespace Generic_Count_Method_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    

    public class GenericCountMethodString
    {
        public static void Main(string[] args)
        {
            //list for string to compare;
            IList<Box<string>> boxes = new List<Box<string>>();

            //read the number of strings;
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //read the current string;
                var currentString = Console.ReadLine();

                //var for current box obect;
                var currentBox = new Box<string>(currentString);

                //add current string to boxes list;
                boxes.Add(currentBox);
            }

            //var for box to compare;
            var comparableBox = new Box<string>(Console.ReadLine());

            //print thr result;
            Console.WriteLine(CompareCount(boxes, comparableBox));
        }

        static int CompareCount<T>(IList<Box<T>> boxes, Box<T> compareBox)
            where T : IComparable<T>
        {
            int count = 0;

            foreach (var box in boxes)
            {
                if (box.Value.CompareTo(compareBox.Value) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
