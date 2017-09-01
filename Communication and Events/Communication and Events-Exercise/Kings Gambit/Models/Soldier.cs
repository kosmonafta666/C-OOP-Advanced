namespace Kings_Gambit.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Soldier
    {
        public string Name { get; set; }

        public Soldier(string name)
        {
            this.Name = name;
        }

        public abstract void KingUnderAttack(object sender, EventArgs e);
    }
}
