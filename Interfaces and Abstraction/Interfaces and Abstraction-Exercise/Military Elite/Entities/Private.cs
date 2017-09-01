using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Elite.Entities
{
    public class Private : Sodier, IPrivate
    {
        public double Salary { get; private set; }

        public Private(string id, string firstName, string LastName, double salary) 
            : base(id, firstName, LastName)
        {
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}Salary: {this.Salary:f2}";
        }
    }
}
