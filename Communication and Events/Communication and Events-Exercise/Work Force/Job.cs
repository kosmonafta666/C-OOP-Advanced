namespace Work_Force
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Work_Force.Employees;

    public class Job
    {
        public event StartUp.JobDoneEventHandler JobDone;

        public string Name { get; private set; }

        public int WorkHoursRequired { get; private set; }

        public BaseEmployee Employee { get; private set; }

        public bool IsDone { get; private set; }

        public Job(string name, int workHours, BaseEmployee employee)
        {
            this.Name = name;
            this.WorkHoursRequired = workHours;
            this.Employee = employee;
            this.IsDone = false;
        }

        public void Update()
        {
            this.WorkHoursRequired -= this.Employee.WorkHoursPerWeek;
  
            if (this.WorkHoursRequired <= 0 && !this.IsDone)
            {
                if (JobDone != null)
                {
                    JobDone(this, new JobEventArgs(this));
                }              
            }
        }

        public void OnJobDone(object sender, EventArgs e)
        {
            Console.WriteLine($"Job {this.Name} done!");
            IsDone = true;
        }

        public override string ToString()
        {
            return $"Job: {this.Name} Hours Remaining: {this.WorkHoursRequired}";
        }
    }
}
