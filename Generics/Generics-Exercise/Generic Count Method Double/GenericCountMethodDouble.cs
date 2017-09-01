namespace Generic_Count_Method_Double
{
    using Generic_Count_Method_Double;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    
    public class GenericCountMethodDouble
    {
        public static void Main(string[] args)
        {
            //list for doubles to compare;
            IList<Box<double>> boxes = new List<Box<double>>();

            //read the number of doubles;
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //read the current double;
                var currentString = double.Parse(Console.ReadLine());

                //var for current box obect;
                var currentBox = new Box<double>(currentString);

                //add current double to boxes list;
                boxes.Add(currentBox);
            }

            //var for box to compare;
            var comparableBox = new Box<double>(double.Parse(Console.ReadLine()));

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
