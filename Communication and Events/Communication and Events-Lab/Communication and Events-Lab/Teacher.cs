using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication_and_Events_Lab
{
    public class Teacher
    {
        public event EventHandler startTalking;

        public string Name { get; set; }

        public void StartClass()
        {
            this.startTalking(this, EventArgs.Empty);
        }
    }
}
