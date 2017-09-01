namespace Strategy_Pattern
{
    using Strategy_Pattern.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StrategyPattern
    {
        public static void Main(string[] args)
        {
            //var for name sorted set;
            var namedSet = new SortedSet<Person>(new NameComparator());
            //var for age sorted set;
            var ageSet = new SortedSet<Person>(new AgeComparator());

            //read the number of persons;
            var n = int.Parse(Console.ReadLine());

            //read the persons, create it and add it to sorted sets;
            for (int i = 0; i < n; i++)
            {
                //read the current person;
                var token = Console.ReadLine()
                    .Split(' ');

                var currentPerson = new Person(token[0], int.Parse(token[1]));

                //add person to sorted sets;
                namedSet.Add(currentPerson);

                ageSet.Add(currentPerson);
            }


            //print the result;
            Console.WriteLine(string.Join(Environment.NewLine, namedSet));

            Console.WriteLine(string.Join(Environment.NewLine, ageSet));

        }
    }
}
