namespace Work_Force.Employees
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PartTimeEmployee : BaseEmployee
    {
        private const int WorkHours = 20;

        public PartTimeEmployee(string name) 
            : base(name, WorkHours)
        {
        }
    }
}
