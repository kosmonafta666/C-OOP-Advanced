namespace Food_Shortage.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Citizen : Human
    {
        private string birthdate;
        private string id;

        public Citizen(string name, int age, string id, string birthdate)
            : base(name, age)
        {
            this.Id = id;
            this.Birthdate = birthdate;
            this.Food = 0;
        }

        public string Birthdate
        {
            get { return this.birthdate; }

            set { this.birthdate = value; }
        }

        public string Id
        {
            get { return this.id; }

            set { this.id = value; }
        }

        public override void BuyFood()
        {
            base.Food += 10;
        }
    }
}
