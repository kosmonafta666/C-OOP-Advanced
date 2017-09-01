using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Elite.Entities
{
    public class Spy : Sodier, ISpy
    {
        public int CodeNumber { get; private set; }

        public Spy(string id, string firstName, string LastName, int codeNumber) 
            : base(id, firstName, LastName)
        {
            this.CodeNumber = codeNumber;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" + Environment.NewLine + $"Code Number: {this.CodeNumber}";
        }
    }
}
