namespace Food_Shortage.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public abstract class Human : IBuyer
    {
        private string name;
        private int age;
        private int food;

        protected Human(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }

            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }

            set { this.age = value; }
        }

        public int Food
        {
            get { return this.food; }

            protected set { this.food = value; }
        }

        public abstract void BuyFood();
    }
}
