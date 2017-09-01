namespace Border_Control
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class BorderControl
    {
        public static void Main(string[] args)
        {
            //list for all subjects;
            List<IIdentifable> subjects = new List<IIdentifable>();

            //read the input;
            var input = Console.ReadLine();

            while (input != "End")
            {
                //var for splitted input;
                var token = input
                    .Split(' ')
                    .ToArray();

                if (token.Length > 2)
                {
                    //var for name of human;
                    var humanName = token[0];
                    //var for age of human;
                    var humanAge = int.Parse(token[1]);
                    //var for human id;
                    var humanId = token[2];

                    //var for current human;
                    IIdentifable currentHuman = new Human(humanName, humanAge, humanId);

                    //add current human to subjects;
                    subjects.Add(currentHuman);
                }
                else if (token.Length ==  2)
                {
                    //var for model of robot;
                    var robotModel = token[0];
                    //var for robot id;
                    var robotId = token[1];

                    //var for current robot;
                    IIdentifable currentRobot = new Robot(robotModel, robotId);

                    //add current robot to subjects;
                    subjects.Add(currentRobot);
                }

                input = Console.ReadLine();
            }//end of while loop;

            //read the fake id;
            var fakeId = Console.ReadLine();

            //list for detained subjects;
            var detained = subjects
                .Where(x => x.Id.EndsWith(fakeId))
                .ToList();

            //print the result;
            foreach (var subject in detained)
            {
                Console.WriteLine(subject.Id);
            }
        }
    }
}
