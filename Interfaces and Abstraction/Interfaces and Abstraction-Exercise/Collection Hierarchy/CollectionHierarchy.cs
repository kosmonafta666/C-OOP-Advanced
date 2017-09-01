namespace Collection_Hierarchy
{
    using Collection_Hierarchy.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CollectionHierarchy
    {
        public static void Main(string[] args)
        {
            //read the elements;
            var elements = Console.ReadLine()
                .Split()
                .ToArray();

            //read the nuber of remove operations;
            var removeOps = int.Parse(Console.ReadLine());

            var addCollection = new AddCollection();

            var removeCollection = new AddRemoveCollection();

            var myList = new MyList();

            foreach (var element in elements)
            {
                Console.Write(addCollection.Add(element) + " ");
            }

            Console.WriteLine();

            foreach (var element in elements)
            {
                Console.Write(removeCollection.Add(element) + " ");
            }

            Console.WriteLine();

            foreach (var element in elements)
            {
                Console.Write(myList.Add(element) + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < removeOps; i++)
            {
                Console.Write(removeCollection.Remove() + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < removeOps; i++)
            {
                Console.Write(myList.Remove() + " ");
            }
        }
    }
}
