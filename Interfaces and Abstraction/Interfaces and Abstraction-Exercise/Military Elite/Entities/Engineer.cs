using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Elite.Entities
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public IList<IRepair> Parts { get; private set; }

        public Engineer(string id, string firstName, string LastName, double salary, string corps, IList<IRepair> parts) 
            : base(id, firstName, LastName, salary, corps)
        {
            this.Parts = parts;
        }

        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString() + Environment.NewLine);

            sb.AppendLine("Repairs:");

            sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Parts)}");

            return sb.ToString().Trim();
        }
    }
}
