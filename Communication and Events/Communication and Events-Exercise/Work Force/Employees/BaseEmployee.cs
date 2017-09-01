namespace Work_Force.Employees
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class BaseEmployee
    {
        public string Name { get; private set; }

        public int WorkHoursPerWeek { get; private set; }

        public BaseEmployee(string name, int workHours)
        {
            this.Name = name;
            this.WorkHoursPerWeek = workHours;
        }
    }
}
