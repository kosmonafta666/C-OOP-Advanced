using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Elite.Entities
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public IList<IMission> Missions { get; private set; }

        public Commando(string id, string firstName, string LastName, double salary, string corps, IList<IMission> missions) 
            : base(id, firstName, LastName, salary, corps)
        {
            this.Missions = missions;
        }

        public void CompleteMission()
        {
        }

        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString() + Environment.NewLine);

            sb.AppendLine("Missions:");

            sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Missions)}");

            return sb.ToString().Trim();
        }
    }
}
