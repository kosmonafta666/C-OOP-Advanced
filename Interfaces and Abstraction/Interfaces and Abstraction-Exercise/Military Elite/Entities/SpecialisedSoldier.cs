using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Elite.Entities
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public string Corps { get; private set; }

        public SpecialisedSoldier(string id, string firstName, string LastName, double salary, string corps) 
            : base(id, firstName, LastName, salary)
        {
            this.Corps = corps;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" + Environment.NewLine + $"Corps: {this.Corps}";
        }
    }
}
