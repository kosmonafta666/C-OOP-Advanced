using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Elite.Entities
{
    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public IList<ISoldier> Soldiers { get; private set; }

        public LeutenantGeneral(string id, string firstName, string LastName, double salary, IList<ISoldier> soldiers) 
            : base(id, firstName, LastName, salary)
        {
            this.Soldiers = soldiers;
        }

        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString() + Environment.NewLine);

            sb.AppendLine("Privates:");

            sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Soldiers)}");

            return sb.ToString().Trim();
        }
    }
}
