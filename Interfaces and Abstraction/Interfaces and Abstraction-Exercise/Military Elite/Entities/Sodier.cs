using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Elite.Entities
{
    public abstract class Sodier : ISoldier
    {
        public string Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public Sodier(string id, string firstName, string LastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = LastName;
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} ";
        }
    }  
}
