namespace Food_Shortage.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Rebel : Human
    {
        private string group;

        public Rebel(string name, int age, string group)
            : base(name, age)
        {
            this.Group = group;
            this.Food = 0;
        }

        public string Group
        {
            get { return this.group; }

            set { this.group = value; }
        }

        public override void BuyFood()
        {
            base.Food += 5;
        }
    }
}
