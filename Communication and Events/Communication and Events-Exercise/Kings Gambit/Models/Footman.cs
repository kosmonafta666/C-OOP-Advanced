using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kings_Gambit.Models
{
    public class Footman : Soldier
    {
        public Footman(string name) 
            : base(name)
        {
        }

        public override void KingUnderAttack(object sender, EventArgs e)
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}
