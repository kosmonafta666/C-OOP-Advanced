namespace Work_Force
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Work_Force.Employees;

    public class StartUp
    {
        public delegate void JobDoneEventHandler(object sender, JobEventArgs e);

        public static void Main(string[] args)
        {
            //list of jobs;
            JobList jobs = new JobList();
            //list of employees;
            List<BaseEmployee> employees = new List<BaseEmployee>();

            //read the commands;
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                //split the command;
                var tokens = command.Split(' ').ToList();

                switch (tokens[0])
                {
                    case "Job":
                        Job realJob = new Job(tokens[1], int.Parse(tokens[2]), 
                            employees.FirstOrDefault(x => x.Name == tokens[3]));

                        realJob.JobDone += realJob.OnJobDone;

                        jobs.Add(realJob);
                        break;

                    case "StandartEmployee":
                        employees.Add(new StandartEmployee(tokens[1]));
                        break;

                    case "PartTimeEmployee":
                        employees.Add(new PartTimeEmployee(tokens[1]));
                        break;

                    case "Pass":
                        foreach (var job in jobs)
                        {
                            job.Update();                           
                        }
                        break;

                    case "Status":
                        foreach (var job in jobs)
                        {
                            if (!job.IsDone == true)
                            {
                                Console.WriteLine(job.ToString());
                            }                            
                        }
                        break;
                }//end of while loop;
            }
        }
    }
}
