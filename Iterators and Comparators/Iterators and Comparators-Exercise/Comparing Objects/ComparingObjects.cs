namespace Comparing_Objects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ComparingObjects
    {
        public static void Main(string[] args)
        {
            //list for persons;
            var persons = new List<Person>();

            //read the persons;
            string inputLine;

            while((inputLine = Console.ReadLine()) != "END")
            {
                //split the inpit line;
                var tokens = inputLine
                    .Split(' ')
                    .ToArray();

                //var for name of the current person;
                var name = tokens[0];
                //var for age of the curent person;
                var age = int.Parse(tokens[1]);
                //var for town of the current person;
                var town = tokens[2];

                //create current person and add to person list;
                var currentPerson = new Person(name, age, town);

                persons.Add(currentPerson);
            }//end of the while loop;

            //read the index of the pattern person;
            var indexPattern = int.Parse(Console.ReadLine());

            //pattern person;
            var patternPerson = persons[indexPattern - 1];

            //list to search the matches;
            var matchedPersons = persons
                .Where(x => x != patternPerson)
                .ToList();

            //var for count of the matches;
            var matchesCount = 0;

            //find the matches;
            foreach (var person in matchedPersons)
            {
                if (patternPerson.CompareTo(person) == 0)
                {
                    matchesCount++;
                }
            }

            //print the result;
            if (matchesCount == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matchesCount + 1} {persons.Count - (matchesCount + 1)} {persons.Count}");
            }
        }
    }
}
