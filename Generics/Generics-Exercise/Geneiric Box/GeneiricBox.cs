namespace Geneiric_Box
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GeneiricBox
    {
        public static void Main(string[] args)
        {
            //read the number of elements;
            var numberOfElements = int.Parse(Console.ReadLine());

            //list of boxes;
            List<Box<int>> boxes = new List<Box<int>>();

            for (int i = 0; i < numberOfElements; i++)
            {

                //read the current string element;
                var currElement = int.Parse(Console.ReadLine());

                //create box elelment and add it to boxes list;
                Box<int> box = new Box<int>(currElement);

                boxes.Add(box);
            }

            //read the indexes to swap in boxes list;
            var indexes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            SwapElelments(boxes, indexes[0], indexes[1]);

            Console.WriteLine(string.Join(Environment.NewLine, boxes));
        }

        //methos to swap elements in boxes list;
        private static void SwapElelments<T>(List<T> boxes, int index1, int index2)
        {
            var temp = boxes[index2];

            boxes[index2] = boxes[index1];

            boxes[index1] = temp;
        }
    }
}
